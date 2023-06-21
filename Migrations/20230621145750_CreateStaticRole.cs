using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MnsGames.Migrations
{
    public partial class CreateStaticRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "biva7896-ez7f-ehvphz-nmqm917za4db",
                column: "ConcurrencyStamp",
                value: "f63eb0dd-2fa1-496a-9c56-54a56880114b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bivz7894-ez8e-ehvnvz-nmqm719za4ea",
                column: "ConcurrencyStamp",
                value: "2e580bfd-b227-480b-b68b-ca5ff0b7d0bc");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17b4691e-4119-4ed4-990a-dc5186439777",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "528459fc-5b6d-4f3f-aaa8-87784eb25036", "AQAAAAEAACcQAAAAEMOM5BS0fBSa27lsotxJSoz65U5gFstVC6mmkTi6AtBojKF8HmHpkqBAGOGsZ4wvZg==", "6d217acc-5103-4c75-be61-fcc4b22f7521" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "367ee742-981e-470d-a02f-5decca03e7a8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "42976852-e39b-4d1c-bc20-dd4eb634d97a", "AQAAAAEAACcQAAAAEMDyRkrW7LdIyzXjcoZs36BOvCecuhSF7fjXPQUj/Ji35apGSet9CD/zz1RQHpXSjg==", "ef733316-1c1a-4600-a8e2-5c8f7eb8d937" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "biva7896-ez7f-ehvphz-nmqm917za4db",
                column: "ConcurrencyStamp",
                value: "c5349018-09a1-48fd-b1d7-a0aba7c92a3b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bivz7894-ez8e-ehvnvz-nmqm719za4ea",
                column: "ConcurrencyStamp",
                value: "c84c5b2a-d4f9-4033-b50a-6fb4487eb823");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17b4691e-4119-4ed4-990a-dc5186439777",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a288bd51-02d7-426a-b2b6-c8bfeb07536f", "AQAAAAEAACcQAAAAEGzci1zLSfNZv2yH8N0D1jVYDPckoYLvnJmagIxOedGde3fnwd42FX+xVMVzcj54fw==", "ee138baf-a36c-40fa-a839-f791261cfd83" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "367ee742-981e-470d-a02f-5decca03e7a8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fd71e7bd-ae6c-41e0-be0c-e2e1dc9651af", "AQAAAAEAACcQAAAAEEHOiro2+fbagBCm6R7WCtcVPL8otYElDE1+p90/t9tQ/ohmV5d3VgzQZuSWINXymQ==", "1213d931-3640-4258-8c04-983d1c9121f8" });
        }
    }
}
