using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Coco.utils
{
    internal class saver
    {
        private string savePath = "layout.json";

        public void Save(List<device> devices)
        {
            // JSONシリアル化のオプションを設定
            JsonSerializerOptions options = new JsonSerializerOptions();

            // インデントを有効にして、読みやすい形式で保存する
            options.WriteIndented = true;

            // デバイスのリストをJSON形式にシリアル化
            string json = JsonSerializer.Serialize(devices, options);

            // JSONデータをファイルに保存
            File.WriteAllText(savePath, json);
        }

        public List<device> Load()
        {
            // 保存ファイルが存在しない場合は、空のリストを返す
            if (!File.Exists(savePath))
            {
                return new List<device>();
            }

            // ファイルからJSONデータを読み込む
            string json = File.ReadAllText(savePath);

            // JSONデータをデバイスのリストにデシリアル化して返す
            return JsonSerializer.Deserialize<List<device>>(json);
        }
    }
}
