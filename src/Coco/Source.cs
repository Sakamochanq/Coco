using Coco.graphics;
using Coco.utils;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Coco
{
    public partial class Source : Form
    {
        public Source()
        {
            InitializeComponent();
        }

        private Background background = new Background();

        private List<device> devices = new List<device>();

        private device selectedDevice = null;

        private bool isDragging = false;

        private Point dragOffset;

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            // 背景の描画
            background.Draw(e.Graphics, this.Font);

            // デバイスの描画
            foreach (device device in devices)
            {
                e.Graphics.FillRectangle(Brushes.DeepSkyBlue, device.Cord);

                //e.Graphics.DrawRectangle(Pens.Black, device.Cord);

                if (device == selectedDevice)
                {
                    e.Graphics.DrawRectangle(new Pen(Color.Red, 3), device.Cord);
                }
                else
                {
                    e.Graphics.DrawRectangle(Pens.Black, device.Cord);
                }
            }

        }

        private void AddObjectButton1_Click(object sender, System.EventArgs e)
        {
            // 配置をずらす為のオフセット
            int offset = devices.Count * 20;

            // 新規オブジェクトの追加
            device pc = new device
            {
                ID = 001,
                Name = "PC",
                User = "",
                Cord = new Rectangle(100 + offset, 100 + offset, 70, 40)
            };

            // デバイスリストに追加
            devices.Add(pc);

            // ListBoxに登録
            ObjectListBox.Items.Add(pc);

            // 画面を再描画
            pictureBox.Invalidate();

        }

        private void AddObjectButton2_Click(object sender, System.EventArgs e)
        {
            AddObjectButton1_Click(sender, e);
        }

        private void ObjectListBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (ObjectListBox.SelectedItem is device selectedDevice)
            {
                Objectproperty.SelectedObject = selectedDevice;
            }
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            selectedDevice = null;

            foreach (device device in devices)
            {
                if (device.Cord.Contains(e.Location))
                {
                    // 選択状態にする
                    selectedDevice = device;

                    // 選択中のオブジェクトをプロパティに表示
                    Objectproperty.SelectedObject = device;

                    // ListBoxでオブジェクトを選択状態にする
                    ObjectListBox.SelectedItem = device;

                    // ドラッグ移動開始
                    isDragging = true;

                    // 位置の計算
                    dragOffset = new Point(e.X - device.Cord.X, e.Y - device.Cord.Y);

                    break;
                }
            }

            // 画面を再描画
            pictureBox.Invalidate();
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            // もしドラッグ中で、かつ選択されたデバイスがある場合
            if (isDragging && selectedDevice != null)
            {
                // デバイスの位置を更新
                int newX = e.X - dragOffset.X;
                int newY = e.Y - dragOffset.Y;

                // 左端制限
                if (newX < 0)
                {
                    newX = 0;
                }

                // 上端制限
                if (newY < 0)
                {
                    newY = 0;
                }

                // 右端制限
                if (newX + selectedDevice.Cord.Width > pictureBox.Width)
                {
                    newX = pictureBox.Width - selectedDevice.Cord.Width;
                }

                // 下端制限
                if (newY + selectedDevice.Cord.Height > pictureBox.Height)
                {
                    newY = pictureBox.Height - selectedDevice.Cord.Height;
                }

                selectedDevice.Cord = new Rectangle(
                    newX,
                    newY,
                    selectedDevice.Cord.Width,
                    selectedDevice.Cord.Height
                );

                // プロパティを更新
                Objectproperty.Refresh();

                // 画面を再描画
                pictureBox.Invalidate();
            }
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            // ドラッグ移動終了
            isDragging = false;
        }
    }
}
