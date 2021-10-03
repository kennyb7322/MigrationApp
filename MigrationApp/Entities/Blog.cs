using System;
namespace MigrationApp.Entities
{
     //  エンティティクラス
    public class Blog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        // 以下のプロパティを追加
        public string Genre { get; set; }
    }
}
