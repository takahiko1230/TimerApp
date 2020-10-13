using System;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using System.Xml.Linq;
using MakeLog;

namespace TimerApp
{
    public partial class Form1 : Form
    {
        public static System.Threading.Timer timer = null;
        DateTime dateTime;


        public Form1()
        {
            InitializeComponent();
            CreateLogger();
            TimeStart();

        }

        public void CreateLogger()
        {
            XDocument xml = XDocument.Load(@"C:\Users\takah\OneDrive\ドキュメント\Timer\TimerApp\TimerApp\Pass.xml");
            Logger.Initialize(xml);
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
            DisplayTime.Text = String.Format("{0}時{1}分です。", dateTime.Hour, dateTime.Minute);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //チェックボックスごとの計測
            if (radio30.Checked)
            {
                StartTimer(30);
                Logger.WriteLine("30分が選択されました");
            }
            if (radio60.Checked)
            {
                StartTimer(60);
                Logger.WriteLine("60分が選択されました");
            }
            if (radio120.Checked)
            {
                StartTimer(120);
                Logger.WriteLine("120分が選択されました");
            }
        }

        public void StartTimer(int resTime)
        {
            //ボタンを押させない
            radio30.Enabled = false;
            radio60.Enabled = false;
            radio120.Enabled = false;

            System.Threading.Timer thrTime = null;
            //タイマー終了時に呼び出す関数
            TimerCallback resDelegate = new TimerCallback(ResCallBack);

            //タイマー終了までの分数を算出
            int timerTime = resTime * 60000;

            //終了時刻の表示
            DateTime addTime = dateTime.AddMinutes(resTime);
            FinTimer.Text = String.Format("終了予定時刻：{0}時{1}分", addTime.Hour, addTime.Minute);
            Logger.WriteLine(String.Format("終了予定時刻：{0}時{1}分", addTime.Hour, addTime.Minute));

            //指定分数後に指定の関数を呼び出す
            thrTime = new System.Threading.Timer(resDelegate, null, timerTime, timerTime);
        }

        public void ResCallBack(object obj)
        {
            MessageBox.Show("タイマー", "タイマーが終了しました", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //ボタンを押せる用に変更
            radio30.Enabled = true;
            radio60.Enabled = true;
            radio120.Enabled = true;
            Logger.WriteLine("タイマー終了");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // 質問ダイアログを表示する
            DialogResult result = MessageBox.Show("ウィンドウを閉じますか？", "質問", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                // はいボタンをクリックしたときはウィンドウを閉じる
                e.Cancel = true;
                Logger.Close();
            }
        }
    }
}