namespace DemoAjaxPartialView.UI.MVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Wlan", "SN", c => c.String(maxLength: 50, unicode: false));
            AlterColumn("dbo.Wlan", "Modelo", c => c.String(maxLength: 50, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Wlan", "Modelo", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.Wlan", "SN", c => c.String(nullable: false, maxLength: 50, unicode: false));
        }
    }
}
