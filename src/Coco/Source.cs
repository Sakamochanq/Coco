using Coco.graphics;
using Coco.utils;
using System;
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

            // 列を追加
            ObjectListView.Columns.Add("ID", 130);
            ObjectListView.Columns.Add("Name", 50);
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
                using (SolidBrush brush = new SolidBrush(device.ObjectColor))
                {
                    e.Graphics.FillRectangle(brush, device.Cord);
                }


                if (device == selectedDevice)
                {
                    e.Graphics.DrawRectangle(new Pen(Color.Red, 3), device.Cord);
                }
                else
                {
                    e.Graphics.DrawRectangle(Pens.Black, device.Cord);
                }

                using (Font font = new Font(this.Font.FontFamily, device.TextSize))
                using (SolidBrush textBrush = new SolidBrush(device.TextColor))
                {
                    // テキストの描画
                    StringFormat format = new StringFormat();

                    // テキストを中央に配置
                    format.Alignment = StringAlignment.Center;
                    format.LineAlignment = StringAlignment.Center;

                    e.Graphics.DrawString(device.Name, font, textBrush, device.Cord, format);
                }
            }

        }

        private void AddObjectButton1_Click(object sender, System.EventArgs e)
        {
            // 配置をずらす為のオフセット
            int offset = devices.Count * 20;

            //ランダムIDの生成
            int randomID = new Random().Next(1000000, 9999999);

            // 新規オブジェクトの追加
            device pc = new device
            {
                ID = $"PC-{randomID.ToString()}",
                Name = null,
                User = null,
                Cord = new Rectangle(100 + offset, 100 + offset, 70, 40)
            };

            // デバイスリストに追加
            devices.Add(pc);

            // ListViewに登録
            ListViewItem item = new ListViewItem(pc.ID.ToString());

            item.SubItems.Add(pc.Name);
            item.Tag = pc;

            ObjectListView.Items.Add(item);


            // 画面を再描画
            pictureBox.Invalidate();

        }

        private void AddObjectButton2_Click(object sender, System.EventArgs e)
        {
            AddObjectButton1_Click(sender, e);
        }

        private void ObjectListBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (ObjectListView.SelectedItems.Count > 0)
            {
                ListViewItem item = ObjectListView.SelectedItems[0];

                device selectedDevice = (device)item.Tag;

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

                    // ListViewでオブジェクトを選択状態にする
                    foreach (ListViewItem item in ObjectListView.Items)
                    {
                        if (item.Tag == device)
                        {
                            item.Selected = true;
                            break;
                        }
                    }

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

                selectedDevice.Cord = new Rectangle(newX, newY, selectedDevice.Cord.Width, selectedDevice.Cord.Height);

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

        private void Objectproperty_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        { 
            // PictureBox再描画
            pictureBox.Invalidate();

            // ListView更新
            if (selectedDevice != null)
            {
                foreach (ListViewItem item in ObjectListView.Items)
                {
                    if (item.Tag == selectedDevice)
                    {
                        item.Text = selectedDevice.ID.ToString();

                        item.SubItems[1].Text = selectedDevice.Name;

                        break;
                    }
                }
            }
        }

        private void DelObjectButton1_Click(object sender, System.EventArgs e)
        {
            // 選択されたオブジェクトを削除
            if (selectedDevice != null)
            {
                // device削除
                devices.Remove(selectedDevice);

                // ListView削除
                foreach (ListViewItem item in ObjectListView.Items)
                {
                    if (item.Tag == selectedDevice)
                    {
                        ObjectListView.Items.Remove(item);
                        break;
                    }
                }

                // PropertyGridクリア
                Objectproperty.SelectedObject = null;

                // 選択解除
                selectedDevice = null;

                // 再描画
                pictureBox.Invalidate();
            }
        }

        private void DelObjectButton2_Click(object sender, System.EventArgs e)
        {
            DelObjectButton1_Click(sender, e);
        }

        private void ObjectListView_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (ObjectListView.SelectedItems.Count > 0)
            {
                // 選択されたListViewItemを取得
                ListViewItem item = ObjectListView.SelectedItems[0];

                // ListViewのTagからdeviceを取得
                device selected = (device)item.Tag;

                // 選択中device更新
                selectedDevice = selected;

                // PropertyGrid表示
                Objectproperty.SelectedObject = selected;

                // PictureBox再描画
                pictureBox.Invalidate();
            }
        }
    }
}
