using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using System.Windows.Forms.DataVisualization.Charting;

namespace GUI
{
    public partial class frm_LN : Form
    {
        BLL_LoiNhuan ln = new BLL_LoiNhuan();
        BLL_TKDV dv = new BLL_TKDV();   
        BLL_TKPT pt  = new BLL_TKPT();  
        public frm_LN()
        {
            InitializeComponent();
        }

        private void frm_LN_Load(object sender, EventArgs e)
        {
            
        }
        ReportDataSource rptdata = new ReportDataSource();
        bool check_chon(int thang, int nam, string loai)
        {
            if(thang == 0 && nam == 0 || loai =="")
            {
                return false;
            }
            else
            {
                return true;    
            }
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            int thang, nam;
            int.TryParse(cbo_thang.Text, out thang);
            int.TryParse(cbo_nam.Text, out nam);    
            if(check_chon(thang,nam,cbo_loai.Text) == false)
            {
                MessageBox.Show("Vui lòng thông tin không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (cbo_loai.Text == "Dịch vụ được sử dụng")
                {
                    reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.Report_TKDV.rdlc";
                    rptdata.Name = "DataSet1";
                    rptdata.Value = dv.get_TKDV(thang, nam);
                    reportViewer1.LocalReport.DataSources.Add(rptdata);
                    this.reportViewer1.RefreshReport();
                    chart1.Series.Clear();
                    chart1.Titles.Clear();
                    string title = string.Format("Dịch vụ được sử dụng trong tháng {0} năm {1}", thang,nam);
                    chart1.Titles.Add(title);
                    chart1.ChartAreas[0].AxisX.Title = "Dịch vụ";
                    chart1.ChartAreas[0].AxisY.Title = "Số lần sử dụng";
                    Series series = new Series
                    {
                        Name = "Số lần sử dụng",
                        IsVisibleInLegend = true,
                        ChartType = SeriesChartType.Column
                    };
                    chart1.Series.Add(series);
                    foreach (DataRow row in dv.get_TKDV(thang, nam).Rows)
                    {
                        series.Points.AddXY(row["dichvu"], row["sudung"]);
                    }

                    chart1.Invalidate();
                    chart2.Series.Clear();
                    chart2.Titles.Clear();
                    chart2.Titles.Add(title);
                    chart2.Legends.Clear();
                    chart2.Legends.Add(new Legend("Legend1"));
                    Series series_tron = new Series
                    {
                        Name = "Số lần sử dụng",
                        IsVisibleInLegend = true,
                        ChartType = SeriesChartType.Pie
                    };
                    chart2.Series.Add(series_tron);
                    
                    foreach (DataRow row in dv.get_TKDV(thang, nam).Rows)
                    {
                        string categoryName = row["dichvu"].ToString();
                        int doanhthu = Convert.ToInt32(row["sudung"]);
                        string lbl = doanhthu < 0 ? $"({Math.Abs(doanhthu).ToString("C")})" : doanhthu.ToString("C");
                        if (doanhthu < 0)
                        {
                            continue; // Bỏ qua các giá trị âm trong biểu đồ tròn
                        }
                        DataPoint point = new DataPoint(0, doanhthu)
                        {
                            Label = lbl,
                            LegendText = categoryName,
                        };
                        series_tron.Points.Add(point);
                    }
                    chart2.Invalidate();

                }
                else if (cbo_loai.Text == "Doanh thu lợi nhuận")
                {
                   
                    reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.Report_TKLN.rdlc";
                    //ReportDataSource rptdata = new ReportDataSource();
                    rptdata.Name = "DataSet1";
                    rptdata.Value = ln.get_LN(thang, nam);
                    reportViewer1.LocalReport.DataSources.Add(rptdata);
                    this.reportViewer1.RefreshReport();
                    chart1.Series.Clear();
                    chart1.Titles.Clear();
                    string title = string.Format("Doanh thu lợi nhuận trong tháng {0} năm {1}", thang, nam);
                    chart1.Titles.Add(title);
                    chart1.ChartAreas[0].AxisX.Title = "Tháng";
                    chart1.ChartAreas[0].AxisY.Title = "Doanh Thu";
                    Series series = new Series
                    {
                        Name = "Tháng",
                        IsVisibleInLegend = true,
                        ChartType = SeriesChartType.Column
                    };
                    chart1.Series.Add(series);
                    foreach (DataRow row in ln.get_LN(thang, nam).Rows)
                    {
                        series.Points.AddXY(row["Thang"], row["DoanhThu"]);
                    }

                    chart1.Invalidate();
                    chart2.Series.Clear();
                    chart2.Titles.Clear();
                    chart2.Titles.Add(title);
                    chart2.Legends.Clear();
                    chart2.Legends.Add(new Legend("Legend1"));
                    Series series_tron = new Series
                    {
                        Name = "Tháng",
                        IsVisibleInLegend = true,
                        ChartType = SeriesChartType.Pie
                    };
                    chart2.Series.Add(series_tron);
                    foreach (DataRow row in ln.get_LN(thang, nam).Rows)
                    {
                        string categoryName = row["Thang"].ToString();
                        int doanhthu = Convert.ToInt32(row["DoanhThu"]);
                        string lbl = doanhthu < 0 ? $"({Math.Abs(doanhthu).ToString("C")})" : doanhthu.ToString("C");
                        if (doanhthu < 0)
                        {
                            continue; // Bỏ qua các giá trị âm trong biểu đồ tròn
                        }
                        DataPoint point = new DataPoint(0, doanhthu)
                        {
                            Label = lbl,
                            LegendText = categoryName,
                        };
                        series_tron.Points.Add(point);
                    }

                    chart2.Invalidate();
                }
                else
                {
                    reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.Report_TKPT.rdlc";
                    rptdata.Name = "DataSet1";
                    rptdata.Value = pt.get_TKPT(thang, nam);
                    reportViewer1.LocalReport.DataSources.Add(rptdata);
                    this.reportViewer1.RefreshReport();
                    chart1.Series.Clear();
                    chart1.Titles.Clear();
                    string title = string.Format("Dịch vụ được sử dụng trong tháng {0} năm {1}", thang, nam);
                    chart1.Titles.Add(title);
                    chart1.ChartAreas[0].AxisX.Title = "Dịch vụ";
                    chart1.ChartAreas[0].AxisY.Title = "Số lần sử dụng";
                    Series series = new Series
                    {
                        Name = "Số lần sử dụng",
                        IsVisibleInLegend = true,
                        ChartType = SeriesChartType.Column
                    };
                    chart1.Series.Add(series);
                    foreach (DataRow row in pt.get_TKPT(thang, nam).Rows)
                    {
                        series.Points.AddXY(row["ten_pt"], row["slhangban"]);
                    }

                    chart1.Invalidate();
                    chart2.Series.Clear();
                    chart2.Titles.Clear();
                    chart2.Titles.Add(title);
                    chart2.Legends.Clear();
                    chart2.Legends.Add(new Legend("Legend1"));
                    Series series_tron = new Series
                    {
                        Name = "Số lần sử dụng",
                        IsVisibleInLegend = true,
                        ChartType = SeriesChartType.Pie
                    };
                    chart2.Series.Add(series_tron);

                    foreach (DataRow row in pt.get_TKPT(thang, nam).Rows)
                    {
                        string categoryName = row["ten_pt"].ToString();
                        int doanhthu = Convert.ToInt32(row["slhangban"]);
                        string lbl = doanhthu < 0 ? $"({Math.Abs(doanhthu).ToString("C")})" : doanhthu.ToString("C");
                        if (doanhthu < 0)
                        {
                            continue; // Bỏ qua các giá trị âm trong biểu đồ tròn
                        }
                        DataPoint point = new DataPoint(0, doanhthu)
                        {
                            Label = lbl,
                            LegendText = categoryName,
                        };
                        series_tron.Points.Add(point);
                    }
                    chart2.Invalidate();
                }

            }
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
