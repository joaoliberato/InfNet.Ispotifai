using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InfNet.Ispotifai.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddPlanos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
INSERT INTO Plano (Nome) VALUES
('Básico'),
('Familía'),
('Premium')
");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
