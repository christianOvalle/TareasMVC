using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TareasMVC.Migrations
{
    /// <inheritdoc />
    public partial class AddRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"IF NOT EXISTS(select Id from AspNetRoles where Id = '9a3389dd-10ab-4287-9803-ff2322587414')
BEGIN
   insert AspNetRoles(Id,[Name], [NormalizedName])
   values('9a3389dd-10ab-4287-9803-ff2322587414', 'admin','ADMIN')
END");
        }  

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("9a3389dd-10ab-4287-9803-ff2322587414");
        }
    }
}
