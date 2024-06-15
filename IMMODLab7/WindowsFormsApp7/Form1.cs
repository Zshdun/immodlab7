using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        private double GetRandomDouble(double minValue, double maxValue)
        {
            return minValue + rnd.NextDouble() * (maxValue - minValue);
        }
        private Random rnd = new Random();
        private int xValue = 0;


        public double TownArea;
        private double TownDiameter;



        private double AmbulancesCnt;
        private double SickPeopleCnt;
        private double AverageDistance;
        private double HospitalCnt;
        private double EstimatedWaitingTime;
        private double Budget;


        private double cnt1 = 0;
        private double cnt2 = 0;
        private double cnt3 = 0;
        private void CalcAvgDistance()
        {
            AverageDistance = TownDiameter / (HospitalCnt + 1) / 2;
            AvgDistanceLabel.Text = AverageDistance.ToString("F2") + " km";
        }

        private void CalcSickPeopleCnt()
        {
            SickPeopleCnt = Convert.ToInt32(rnd.Next(10, 30) * TownArea / 10);
            SickPeopleCnt = Math.Round(SickPeopleCnt);
            SickPeopleCntLabel.Text = SickPeopleCnt.ToString() + " чел";
        }

        private void CalcAmbulancesCnt()
        {
            
            double idk = Budget / AmbulancesCnt;
            if (idk > 5000)
            {
                cnt1++;
            }
            if (cnt1 == 5)
            {
                AmbulancesCnt = AmbulancesCnt + 5;
                cnt1 = 0;
            }
            AmbulancesCntLabel.Text = AmbulancesCnt.ToString();
        }

        private void CalcEstimatedWaitingTime()
        {
            EstimatedWaitingTime = 5 + (AverageDistance / 40 * 60); // 5 минут для посадки и высадки и время поездки при средней скорости 40 км/ч
            double idk2 = SickPeopleCnt / AmbulancesCnt;
            if (idk2 > 30)
                EstimatedWaitingTime = EstimatedWaitingTime + (idk2 - 20) * 3;

            EstimatedWaitingTimeLabel.Text = EstimatedWaitingTime.ToString("F2") + " мин";
        }

        private void CalcBudget()
        {
            if (EstimatedWaitingTime > 20)
                
            { cnt2++; }
            if (cnt2 == 5)
            { Budget = Budget * 1.2;
                cnt2 = 0;
            }
            BudgetLabel.Text = Budget.ToString("F2") + " тыс ₽";
        }

        private void CalcHospitalCnt()
        {
            double idk3 = Budget / HospitalCnt;

            if (idk3 > 100000)
            {
                cnt3++;
            }
            if (cnt3 ==8)
            {
                HospitalCnt = HospitalCnt + 1;
                cnt3= 0;
            }
            HospitalCntLabel.Text = HospitalCnt.ToString();
        }

        private void DrawPoint(double yValue)
        {
            // Добавление точки в серию данных
            chart1.Series[0].Points.AddXY(xValue, yValue);

            // Перерисовка графика
            chart1.Invalidate();

            xValue++;
        }

        private void Calculate()
        {
            CalcAvgDistance();
            CalcSickPeopleCnt();
            CalcAmbulancesCnt();
            CalcEstimatedWaitingTime();
            CalcBudget();
            CalcHospitalCnt();
            DrawPoint(EstimatedWaitingTime);
        }
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 200;

        }

        private void StartBtn_Click_1(object sender, EventArgs e)
        {
            Budget = Convert.ToDouble(BudgetTextBox.Text);
            TownArea = Convert.ToDouble(AreaTextBox.Text);
            TownDiameter = Math.Sqrt(TownArea / Math.PI) * 2;
            AmbulancesCnt = 30;
            HospitalCnt = 3;
            timer1.Start();


        }
        private void StopBtn_Click_1(object sender, EventArgs e)
        {
            timer1.Stop();

        }
        private void timer1_Tick_1(object sender, EventArgs e)
        {


            Calculate();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
