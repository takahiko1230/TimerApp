using System;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace TimerApp
{
    public partial class Form1 : Form
    {
        public static System.Threading.Timer timer=null;
        DateTime dateTime;
        int second;

        ManualResetEvent mre = new ManualResetEvent(false);

        public Form1()
        {
            InitializeComponent();
            TimeStart();
        }
        
        public void TimeStart()
        {
            TimerCallback timerDelegate = new TimerCallback(OnTimeCallback);

            // タイマーを生成し、開始します。
            // 例では1000ミリ秒=1秒間隔で処理を呼び出します。
            timer = new System.Threading.Timer(timerDelegate, null, 0, 1000);

        }

        public void OnTimeCallback(object obj)
        {
            dateTime = DateTime.Now;
            DisplayTime.Text = String.Format("{0}時{1}分です。", dateTime.Hour,dateTime.Minute);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //チェックボックスごとの計測
            if (radio30.Checked)
            {
                StartTimer(30);
            }
            if(radio60.Checked)
            {
                StartTimer(60);
            }
            if(radio120.Checked)
            {
                StartTimer(120);
            }
        }

        public void StartTimer(int resTime)
        {
            System.Threading.Timer thrTime = null;
            //タイマー終了時に呼び出す関数
            TimerCallback resDelegate = new TimerCallback(ResCallBack);

            int timerTime = resTime * 60000;
            DateTime addTime = dateTime.AddMinutes(resTime);
            FinTimer.Text = String.Format("終了予定時刻：{0}時{1}分", addTime.Hour, addTime.Minute);
            thrTime = new System.Threading.Timer(resDelegate, null, timerTime, timerTime);
        }

        public void ResCallBack(object obj) 
        {
            MessageBox.Show("タイマー", "タイマーが終了しました", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}

            