using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InfNet.Ispotifai.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddMusicas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
INSERT INTO Musica (Nome, Album, Artista) VALUES
('Suite-Pee', 'System of a Down', 'System of a Down'),
('Know', 'System of a Down', 'System of a Down'),
('Sugar', 'System of a Down', 'System of a Down'),
('Suggestions', 'System of a Down', 'System of a Down'),
('Spiders', 'System of a Down', 'System of a Down'),
('DDevil', 'System of a Down', 'System of a Down'),
('Soil', 'System of a Down', 'System of a Down'),
('War?', 'System of a Down', 'System of a Down'),
('Mind', 'System of a Down', 'System of a Down'),
('Peephole', 'System of a Down', 'System of a Down'),
('CUBErt', 'System of a Down', 'System of a Down'),
('Darts', 'System of a Down', 'System of a Down'),
('P.L.U.C.K.', 'System of a Down', 'System of a Down'),

('Prison Song', 'Toxicity', 'System of a Down'),
('Needles', 'Toxicity', 'System of a Down'),
('Deer Dance', 'Toxicity', 'System of a Down'),
('Jet Pilot', 'Toxicity', 'System of a Down'),
('X', 'Toxicity', 'System of a Down'),
('Chop Suey!', 'Toxicity', 'System of a Down'),
('Bounce', 'Toxicity', 'System of a Down'),
('Forest', 'Toxicity', 'System of a Down'),
('ATWA', 'Toxicity', 'System of a Down'),
('Science', 'Toxicity', 'System of a Down'),
('Shimmy', 'Toxicity', 'System of a Down'),
('Toxicity', 'Toxicity', 'System of a Down'),
('Psycho', 'Toxicity', 'System of a Down'),
('Aerials', 'Toxicity', 'System of a Down'),
('Arto', 'Toxicity', 'System of a Down'),

('Chic ''N'' Stu', 'Steal This Album!', 'System of a Down'),
('Innervision', 'Steal This Album!', 'System of a Down'),
('Bubbles', 'Steal This Album!', 'System of a Down'),
('Boom!', 'Steal This Album!', 'System of a Down'),
('Nüguns', 'Steal This Album!', 'System of a Down'),
('A.D.D. (American Dream Denial)', 'Steal This Album!', 'System of a Down'),
('Mr. Jack', 'Steal This Album!', 'System of a Down'),
('I-E-A-I-A-I-O', 'Steal This Album!', 'System of a Down'),
('36', 'Steal This Album!', 'System of a Down'),
('Pictures', 'Steal This Album!', 'System of a Down'),
('Highway Song', 'Steal This Album!', 'System of a Down'),
('F**k The System', 'Steal This Album!', 'System of a Down'),
('Ego Brain', 'Steal This Album!', 'System of a Down'),
('Thetawaves', 'Steal This Album!', 'System of a Down'),
('Roulette', 'Steal This Album!', 'System of a Down'),
('Streamline', 'Steal This Album!', 'System of a Down'),

('Soldier Side – Intro', 'Mezmerize', 'System of a Down'),
('B.Y.O.B.', 'Mezmerize', 'System of a Down'),
('Revenga', 'Mezmerize', 'System of a Down'),
('Cigaro', 'Mezmerize', 'System of a Down'),
('Radio/Video', 'Mezmerize', 'System of a Down'),
('This Cocaine Makes Me Feel Like I''m On This Song', 'Mezmerize', 'System of a Down'),
('Violent Pornography', 'Mezmerize', 'System of a Down'),
('Question!', 'Mezmerize', 'System of a Down'),
('Sad Statue', 'Mezmerize', 'System of a Down'),
('Old School Hollywood', 'Mezmerize', 'System of a Down'),
('Lost In Hollywood', 'Mezmerize', 'System of a Down'),

('Attack', 'Hypnotize', 'System of a Down'),
('Dreaming', 'Hypnotize', 'System of a Down'),
('Kill Rock ''N Roll', 'Hypnotize', 'System of a Down'),
('Hypnotize', 'Hypnotize', 'System of a Down'),
('Stealing Society', 'Hypnotize', 'System of a Down'),
('Tentative', 'Hypnotize', 'System of a Down'),
('U-Fig', 'Hypnotize', 'System of a Down'),
('Holy Mountains', 'Hypnotize', 'System of a Down'),
('Vicinity of Obscenity', 'Hypnotize', 'System of a Down'),
('She''s Like Heroin', 'Hypnotize', 'System of a Down'),
('Lonely Day', 'Hypnotize', 'System of a Down'),
('Soldier Side', 'Hypnotize', 'System of a Down'),

('Protect The Land', 'Single', 'System of a Down'),
('Genocidal Humanoidz', 'Single', 'System of a Down');
");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
