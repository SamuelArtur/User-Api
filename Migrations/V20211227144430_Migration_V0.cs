using System;
using FluentMigrator;

namespace UserApi.Migrations
{
    [Migration(20211227144430)]
    public class V20211227144430_Migration_V0 : Migration
    {
        public override void Up()
        {
            Create.Table("User")
                .WithColumn("Id").AsInt32().NotNullable().Identity().PrimaryKey()
                .WithColumn("Name").AsString().NotNullable()
                .WithColumn("Email").AsString().NotNullable()
                .WithColumn("Password").AsString().NotNullable()
                .WithColumn("Wallet").AsDouble();
        }

        public override void Down()
        {
            Delete.Table("User");
        }
    }
}