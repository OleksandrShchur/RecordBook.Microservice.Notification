using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Notification.Db.Migrations
{
    public partial class ConfigureRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NotificationTypes_Notifications_NotificationId",
                table: "NotificationTypes");

            migrationBuilder.DropIndex(
                name: "IX_NotificationTypes_NotificationId",
                table: "NotificationTypes");

            migrationBuilder.AddColumn<Guid>(
                name: "NotificationMessageId",
                table: "NotificationTypes",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_NotificationTypes_NotificationMessageId",
                table: "NotificationTypes",
                column: "NotificationMessageId");

            migrationBuilder.AddForeignKey(
                name: "FK_NotificationTypes_Notifications_NotificationMessageId",
                table: "NotificationTypes",
                column: "NotificationMessageId",
                principalTable: "Notifications",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NotificationTypes_Notifications_NotificationMessageId",
                table: "NotificationTypes");

            migrationBuilder.DropIndex(
                name: "IX_NotificationTypes_NotificationMessageId",
                table: "NotificationTypes");

            migrationBuilder.DropColumn(
                name: "NotificationMessageId",
                table: "NotificationTypes");

            migrationBuilder.CreateIndex(
                name: "IX_NotificationTypes_NotificationId",
                table: "NotificationTypes",
                column: "NotificationId");

            migrationBuilder.AddForeignKey(
                name: "FK_NotificationTypes_Notifications_NotificationId",
                table: "NotificationTypes",
                column: "NotificationId",
                principalTable: "Notifications",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
