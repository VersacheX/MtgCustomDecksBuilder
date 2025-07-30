using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Persistence.Schema
{
    public partial class MtgCustomDecksBuilderContext : DbContext
    {
        public MtgCustomDecksBuilderContext()
        {
        }

        public MtgCustomDecksBuilderContext(DbContextOptions<MtgCustomDecksBuilderContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DeckLocation> DeckLocations { get; set; } = null!;
        public virtual DbSet<DeckRuleCriteriaAllowedSet> DeckRuleCriteriaAllowedSets { get; set; } = null!;
        public virtual DbSet<DeckRuleCriteriaSetType> DeckRuleCriteriaSetTypes { get; set; } = null!;
        public virtual DbSet<DeckRuleCriterion> DeckRuleCriteria { get; set; } = null!;
        public virtual DbSet<GameFormat> GameFormats { get; set; } = null!;
        public virtual DbSet<MtgCard> MtgCards { get; set; } = null!;
        public virtual DbSet<MtgCardForeignName> MtgCardForeignNames { get; set; } = null!;
        public virtual DbSet<MtgCardLegality> MtgCardLegalities { get; set; } = null!;
        public virtual DbSet<MtgCardRuling> MtgCardRulings { get; set; } = null!;
        public virtual DbSet<MtgCardSet> MtgCardSets { get; set; } = null!;
        public virtual DbSet<MtgCardVariation> MtgCardVariations { get; set; } = null!;
        public virtual DbSet<MtgFormat> MtgFormats { get; set; } = null!;
        public virtual DbSet<MtgSet> MtgSets { get; set; } = null!;
        public virtual DbSet<MtgSetType> MtgSetTypes { get; set; } = null!;
        public virtual DbSet<ScryfallCard> ScryfallCards { get; set; } = null!;
        public virtual DbSet<ScryfallCardImageUri> ScryfallCardImageUris { get; set; } = null!;
        public virtual DbSet<ScryfallCardLegality> ScryfallCardLegalities { get; set; } = null!;
        public virtual DbSet<ScryfallCardPrice> ScryfallCardPrices { get; set; } = null!;
        public virtual DbSet<ScryfallCardPurchaseUri> ScryfallCardPurchaseUris { get; set; } = null!;
        public virtual DbSet<ScryfallCardRelatedUri> ScryfallCardRelatedUris { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<UserDeck> UserDecks { get; set; } = null!;
        public virtual DbSet<UserDeckCard> UserDeckCards { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-3K6IPDC;Initial Catalog=MtgCustomDecksBuilder;Integrated Security=True;Trust Server Certificate=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DeckLocation>(entity =>
            {
                entity.HasKey(e => e.DeckLocationPk);

                entity.ToTable("DeckLocation");

                entity.Property(e => e.DeckLocationPk).HasColumnName("DeckLocationPK");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.Name).HasMaxLength(25);
            });

            modelBuilder.Entity<DeckRuleCriteriaAllowedSet>(entity =>
            {
                entity.HasKey(e => e.DeckRuleCriteriaAllowedSetPk);

                entity.ToTable("DeckRuleCriteriaAllowedSet");

                entity.Property(e => e.DeckRuleCriteriaAllowedSetPk).HasColumnName("DeckRuleCriteriaAllowedSetPK");

                entity.Property(e => e.DeckRuleCriteriaFk).HasColumnName("DeckRuleCriteriaFK");

                entity.Property(e => e.MtgSetFk).HasColumnName("MtgSetFK");

                entity.HasOne(d => d.DeckRuleCriteriaFkNavigation)
                    .WithMany(p => p.DeckRuleCriteriaAllowedSets)
                    .HasForeignKey(d => d.DeckRuleCriteriaFk)
                    .HasConstraintName("FK_DeckRuleCriteriaAllowedSet_DeckRuleCriterion");

                entity.HasOne(d => d.MtgSetFkNavigation)
                    .WithMany(p => p.DeckRuleCriteriaAllowedSets)
                    .HasForeignKey(d => d.MtgSetFk)
                    .HasConstraintName("FK_DeckRuleCriteriaAllowedSet_MtgSet");
            });

            modelBuilder.Entity<DeckRuleCriteriaSetType>(entity =>
            {
                entity.HasKey(e => e.DeckRuleCriteriaSetTypePk);

                entity.ToTable("DeckRuleCriteriaSetType");

                entity.Property(e => e.DeckRuleCriteriaSetTypePk).HasColumnName("DeckRuleCriteriaSetTypePK");

                entity.Property(e => e.DeckRuleCriteriaFk).HasColumnName("DeckRuleCriteriaFK");

                entity.Property(e => e.SetTypeFk).HasColumnName("SetTypeFK");

                entity.HasOne(d => d.DeckRuleCriteriaFkNavigation)
                    .WithMany(p => p.DeckRuleCriteriaSetTypes)
                    .HasForeignKey(d => d.DeckRuleCriteriaFk)
                    .HasConstraintName("FK_DeckRuleCriteriaSetType_DeckRuleCriterion");

                entity.HasOne(d => d.SetTypeFkNavigation)
                    .WithMany(p => p.DeckRuleCriteriaSetTypes)
                    .HasForeignKey(d => d.SetTypeFk)
                    .HasConstraintName("FK_DeckRuleCriteriaSetType_MtgSet");
            });

            modelBuilder.Entity<DeckRuleCriterion>(entity =>
            {
                entity.HasKey(e => e.DeckRuleCriterionPk)
                    .HasName("PK_DeckRuleCriteria");

                entity.ToTable("DeckRuleCriterion");

                entity.Property(e => e.DeckRuleCriterionPk).HasColumnName("DeckRuleCriterionPK");

                entity.Property(e => e.GameFormatFk).HasColumnName("GameFormatFK");

                entity.Property(e => e.MtgFormatFk).HasColumnName("MtgFormatFK");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.UserFk).HasColumnName("UserFK");

                entity.HasOne(d => d.GameFormatFkNavigation)
                    .WithMany(p => p.DeckRuleCriteria)
                    .HasForeignKey(d => d.GameFormatFk)
                    .HasConstraintName("FK_DeckRuleCriterion_GameFormat");

                entity.HasOne(d => d.MtgFormatFkNavigation)
                    .WithMany(p => p.DeckRuleCriteria)
                    .HasForeignKey(d => d.MtgFormatFk)
                    .HasConstraintName("FK_DeckRuleCriterion_MtgFormat");

                entity.HasOne(d => d.UserFkNavigation)
                    .WithMany(p => p.DeckRuleCriteria)
                    .HasForeignKey(d => d.UserFk)
                    .HasConstraintName("FK_DeckRuleCriterion_User");
            });

            modelBuilder.Entity<GameFormat>(entity =>
            {
                entity.HasKey(e => e.GameFormatPk);

                entity.ToTable("GameFormat");

                entity.Property(e => e.GameFormatPk).HasColumnName("GameFormatPK");

                entity.Property(e => e.Name).HasMaxLength(25);
            });

            modelBuilder.Entity<MtgCard>(entity =>
            {
                entity.HasKey(e => e.MtgCardPk);

                entity.ToTable("MtgCard");

                entity.Property(e => e.MtgCardPk).HasColumnName("MtgCardPK");

                entity.Property(e => e.Artist).HasMaxLength(50);

                entity.Property(e => e.Border).HasMaxLength(20);

                entity.Property(e => e.Cmc).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ColorIdentity).HasMaxLength(10);

                entity.Property(e => e.Colors).HasMaxLength(50);

                entity.Property(e => e.Flavor).HasMaxLength(500);

                entity.Property(e => e.Hand).HasMaxLength(50);

                entity.Property(e => e.Id).HasMaxLength(50);

                entity.Property(e => e.ImageUrl).HasMaxLength(400);

                entity.Property(e => e.Layout).HasMaxLength(25);

                entity.Property(e => e.Life).HasMaxLength(50);

                entity.Property(e => e.Loyalty).HasMaxLength(50);

                entity.Property(e => e.ManaCost).HasMaxLength(50);

                entity.Property(e => e.MultiverseId).HasMaxLength(15);

                entity.Property(e => e.Name).HasMaxLength(300);

                entity.Property(e => e.Names).HasMaxLength(300);

                entity.Property(e => e.Number).HasMaxLength(20);

                entity.Property(e => e.OriginalText).HasMaxLength(1000);

                entity.Property(e => e.OriginalType).HasMaxLength(50);

                entity.Property(e => e.Power).HasMaxLength(3);

                entity.Property(e => e.Printings).HasMaxLength(1000);

                entity.Property(e => e.Rarity).HasMaxLength(20);

                entity.Property(e => e.ReleaseDate).HasColumnType("datetime");

                entity.Property(e => e.Set).HasMaxLength(10);

                entity.Property(e => e.SetName).HasMaxLength(50);

                entity.Property(e => e.Source)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.SubTypes).HasMaxLength(100);

                entity.Property(e => e.SuperTypes).HasMaxLength(100);

                entity.Property(e => e.Text).IsUnicode(false);

                entity.Property(e => e.Toughness).HasMaxLength(3);

                entity.Property(e => e.Type).HasMaxLength(50);

                entity.Property(e => e.Types).HasMaxLength(100);

                entity.Property(e => e.Watermark).HasMaxLength(50);
            });

            modelBuilder.Entity<MtgCardForeignName>(entity =>
            {
                entity.HasKey(e => e.MtgCardForeignNamePk);

                entity.ToTable("MtgCardForeignName");

                entity.Property(e => e.MtgCardForeignNamePk).HasColumnName("MtgCardForeignNamePK");

                entity.Property(e => e.Language).HasMaxLength(50);

                entity.Property(e => e.MtgCardFk).HasColumnName("MtgCardFK");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.HasOne(d => d.MtgCardFkNavigation)
                    .WithMany(p => p.MtgCardForeignNames)
                    .HasForeignKey(d => d.MtgCardFk)
                    .HasConstraintName("FK_MtgCardForeignName_MtgCard");
            });

            modelBuilder.Entity<MtgCardLegality>(entity =>
            {
                entity.HasKey(e => e.MtgCardLegalityPk);

                entity.ToTable("MtgCardLegality");

                entity.Property(e => e.MtgCardLegalityPk).HasColumnName("MtgCardLegalityPK");

                entity.Property(e => e.Format).HasMaxLength(25);

                entity.Property(e => e.Legality).HasMaxLength(15);

                entity.Property(e => e.MtgCardFk).HasColumnName("MtgCardFK");

                entity.HasOne(d => d.MtgCardFkNavigation)
                    .WithMany(p => p.MtgCardLegalities)
                    .HasForeignKey(d => d.MtgCardFk)
                    .HasConstraintName("FK_MtgCardLegality_MtgCard");
            });

            modelBuilder.Entity<MtgCardRuling>(entity =>
            {
                entity.HasKey(e => e.MtgCardRulingPk);

                entity.ToTable("MtgCardRuling");

                entity.Property(e => e.MtgCardRulingPk).HasColumnName("MtgCardRulingPK");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.MtgCardFk).HasColumnName("MtgCardFK");

                entity.HasOne(d => d.MtgCardFkNavigation)
                    .WithMany(p => p.MtgCardRulings)
                    .HasForeignKey(d => d.MtgCardFk)
                    .HasConstraintName("FK_MtgCardRuling_MtgCard");
            });

            modelBuilder.Entity<MtgCardSet>(entity =>
            {
                entity.HasKey(e => e.MtgCardSetPk);

                entity.ToTable("MtgCardSet");

                entity.Property(e => e.MtgCardSetPk).HasColumnName("MtgCardSetPK");

                entity.Property(e => e.MtgCardFk).HasColumnName("MtgCardFK");

                entity.Property(e => e.MtgSetFk).HasColumnName("MtgSetFK");

                entity.HasOne(d => d.MtgCardFkNavigation)
                    .WithMany(p => p.MtgCardSets)
                    .HasForeignKey(d => d.MtgCardFk)
                    .HasConstraintName("FK_MtgCardSet_MtgCard");

                entity.HasOne(d => d.MtgSetFkNavigation)
                    .WithMany(p => p.MtgCardSets)
                    .HasForeignKey(d => d.MtgSetFk)
                    .HasConstraintName("FK_MtgCardSet_MtgSet");
            });

            modelBuilder.Entity<MtgCardVariation>(entity =>
            {
                entity.HasKey(e => e.MtgCardVariationPk);

                entity.ToTable("MtgCardVariation");

                entity.Property(e => e.MtgCardVariationPk).HasColumnName("MtgCardVariationPK");

                entity.Property(e => e.MtgCardFk).HasColumnName("MtgCardFK");

                entity.Property(e => e.VariationId).HasMaxLength(50);

                entity.HasOne(d => d.MtgCardFkNavigation)
                    .WithMany(p => p.MtgCardVariations)
                    .HasForeignKey(d => d.MtgCardFk)
                    .HasConstraintName("FK_MtgCardVariation_MtgCard");
            });

            modelBuilder.Entity<MtgFormat>(entity =>
            {
                entity.HasKey(e => e.MtgFormatPk);

                entity.ToTable("MtgFormat");

                entity.Property(e => e.MtgFormatPk).HasColumnName("MtgFormatPK");

                entity.Property(e => e.Name).HasMaxLength(25);
            });

            modelBuilder.Entity<MtgSet>(entity =>
            {
                entity.HasKey(e => e.MtgSetPk);

                entity.ToTable("MtgSet");

                entity.Property(e => e.MtgSetPk).HasColumnName("MtgSetPK");

                entity.Property(e => e.Block).HasMaxLength(50);

                entity.Property(e => e.Code).HasMaxLength(10);

                entity.Property(e => e.Expansion).HasMaxLength(100);

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.ReleaseDate).HasColumnType("datetime");

                entity.Property(e => e.Type).HasMaxLength(20);
            });

            modelBuilder.Entity<MtgSetType>(entity =>
            {
                entity.HasKey(e => e.MtgSetTypePk);

                entity.ToTable("MtgSetType");

                entity.Property(e => e.MtgSetTypePk).HasColumnName("MtgSetTypePK");

                entity.Property(e => e.Name).HasMaxLength(20);
            });

            modelBuilder.Entity<ScryfallCard>(entity =>
            {
                entity.HasKey(e => e.ScryfallCardPk)
                    .HasName("PK__Scryfall__55F7FF0019119203");

                entity.ToTable("ScryfallCard");

                entity.Property(e => e.ScryfallCardPk).HasColumnName("ScryfallCardPK");

                entity.Property(e => e.ArenaId).HasColumnName("Arena_Id");

                entity.Property(e => e.Artist).HasMaxLength(100);

                entity.Property(e => e.ArtistIds)
                    .HasMaxLength(200)
                    .HasColumnName("Artist_Ids");

                entity.Property(e => e.BorderColor)
                    .HasMaxLength(20)
                    .HasColumnName("Border_Color");

                entity.Property(e => e.CardBackId)
                    .HasMaxLength(50)
                    .HasColumnName("Card_Back_Id");

                entity.Property(e => e.CollectorNumber)
                    .HasMaxLength(10)
                    .HasColumnName("Collector_Number");

                entity.Property(e => e.ColorIdentity)
                    .HasMaxLength(50)
                    .HasColumnName("Color_Identity");

                entity.Property(e => e.Colors).HasMaxLength(50);

                entity.Property(e => e.Finishes).HasMaxLength(50);

                entity.Property(e => e.Frame).HasMaxLength(20);

                entity.Property(e => e.FullArt).HasColumnName("Full_Art");

                entity.Property(e => e.GameChanger).HasColumnName("Game_Changer");

                entity.Property(e => e.Games).HasMaxLength(50);

                entity.Property(e => e.HighresImage).HasColumnName("Highres_Image");

                entity.Property(e => e.Id).HasMaxLength(50);

                entity.Property(e => e.IllustrationId)
                    .HasMaxLength(50)
                    .HasColumnName("Illustration_Id");

                entity.Property(e => e.ImageStatus)
                    .HasMaxLength(50)
                    .HasColumnName("Image_Status");

                entity.Property(e => e.Lang).HasMaxLength(10);

                entity.Property(e => e.Layout).HasMaxLength(50);

                entity.Property(e => e.ManaCost)
                    .HasMaxLength(50)
                    .HasColumnName("Mana_Cost");

                entity.Property(e => e.MtgoId).HasColumnName("Mtgo_Id");

                entity.Property(e => e.MultiverseIds).HasColumnName("Multiverse_Ids");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.Object).HasMaxLength(50);

                entity.Property(e => e.OracleId)
                    .HasMaxLength(50)
                    .HasColumnName("Oracle_Id");

                entity.Property(e => e.OracleText).HasColumnName("Oracle_Text");

                entity.Property(e => e.PrintsSearchUri)
                    .HasMaxLength(200)
                    .HasColumnName("Prints_Search_Uri");

                entity.Property(e => e.ProducedMana)
                    .HasMaxLength(50)
                    .HasColumnName("Produced_Mana");

                entity.Property(e => e.Rarity).HasMaxLength(50);

                entity.Property(e => e.ReleasedAt)
                    .HasColumnType("date")
                    .HasColumnName("Released_At");

                entity.Property(e => e.RulingsUri)
                    .HasMaxLength(200)
                    .HasColumnName("Rulings_Uri");

                entity.Property(e => e.ScryfallSetUri)
                    .HasMaxLength(200)
                    .HasColumnName("Scryfall_Set_Uri");

                entity.Property(e => e.ScryfallUri)
                    .HasMaxLength(200)
                    .HasColumnName("Scryfall_Uri");

                entity.Property(e => e.Set).HasMaxLength(50);

                entity.Property(e => e.SetId)
                    .HasMaxLength(50)
                    .HasColumnName("Set_Id");

                entity.Property(e => e.SetName)
                    .HasMaxLength(100)
                    .HasColumnName("Set_Name");

                entity.Property(e => e.SetSearchUri)
                    .HasMaxLength(200)
                    .HasColumnName("Set_Search_Uri");

                entity.Property(e => e.SetType)
                    .HasMaxLength(50)
                    .HasColumnName("Set_Type");

                entity.Property(e => e.SetUri)
                    .HasMaxLength(200)
                    .HasColumnName("Set_Uri");

                entity.Property(e => e.StorySpotlight).HasColumnName("Story_Spotlight");

                entity.Property(e => e.TcgplayerId).HasColumnName("Tcgplayer_Id");

                entity.Property(e => e.TypeLine)
                    .HasMaxLength(100)
                    .HasColumnName("Type_Line");

                entity.Property(e => e.Uri).HasMaxLength(200);
            });

            modelBuilder.Entity<ScryfallCardImageUri>(entity =>
            {
                entity.HasKey(e => e.ScryfallCardImageUrisPk)
                    .HasName("PK__Scryfall__DA5005DD11C55432");

                entity.Property(e => e.ScryfallCardImageUrisPk).HasColumnName("ScryfallCardImageUrisPK");

                entity.Property(e => e.ArtCrop)
                    .HasMaxLength(200)
                    .HasColumnName("Art_Crop");

                entity.Property(e => e.BorderCrop)
                    .HasMaxLength(200)
                    .HasColumnName("Border_Crop");

                entity.Property(e => e.Large).HasMaxLength(200);

                entity.Property(e => e.Normal).HasMaxLength(200);

                entity.Property(e => e.Png).HasMaxLength(200);

                entity.Property(e => e.ScryfallCardFk).HasColumnName("ScryfallCardFK");

                entity.Property(e => e.Small).HasMaxLength(200);

                entity.HasOne(d => d.ScryfallCardFkNavigation)
                    .WithMany(p => p.ScryfallCardImageUris)
                    .HasForeignKey(d => d.ScryfallCardFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ScryfallC__Scryf__51300E55");
            });

            modelBuilder.Entity<ScryfallCardLegality>(entity =>
            {
                entity.HasKey(e => e.ScryfallCardLegalitiesPk)
                    .HasName("PK__Scryfall__1FD65129E5913B68");

                entity.Property(e => e.ScryfallCardLegalitiesPk).HasColumnName("ScryfallCardLegalitiesPK");

                entity.Property(e => e.Alchemy).HasMaxLength(20);

                entity.Property(e => e.Brawl).HasMaxLength(20);

                entity.Property(e => e.Commander).HasMaxLength(20);

                entity.Property(e => e.Duel).HasMaxLength(20);

                entity.Property(e => e.Explorer).HasMaxLength(20);

                entity.Property(e => e.Future).HasMaxLength(20);

                entity.Property(e => e.Gladiator).HasMaxLength(20);

                entity.Property(e => e.Historic).HasMaxLength(20);

                entity.Property(e => e.Legacy).HasMaxLength(20);

                entity.Property(e => e.Modern).HasMaxLength(20);

                entity.Property(e => e.Oathbreaker).HasMaxLength(20);

                entity.Property(e => e.Oldschool).HasMaxLength(20);

                entity.Property(e => e.Pauper).HasMaxLength(20);

                entity.Property(e => e.Paupercommander).HasMaxLength(20);

                entity.Property(e => e.Penny).HasMaxLength(20);

                entity.Property(e => e.Pioneer).HasMaxLength(20);

                entity.Property(e => e.Predh).HasMaxLength(20);

                entity.Property(e => e.Premodern).HasMaxLength(20);

                entity.Property(e => e.ScryfallCardFk).HasColumnName("ScryfallCardFK");

                entity.Property(e => e.Standard).HasMaxLength(20);

                entity.Property(e => e.Standardbrawl).HasMaxLength(20);

                entity.Property(e => e.Timeless).HasMaxLength(20);

                entity.Property(e => e.Vintage).HasMaxLength(20);

                entity.HasOne(d => d.ScryfallCardFkNavigation)
                    .WithMany(p => p.ScryfallCardLegalities)
                    .HasForeignKey(d => d.ScryfallCardFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ScryfallC__Scryf__540C7B00");
            });

            modelBuilder.Entity<ScryfallCardPrice>(entity =>
            {
                entity.HasKey(e => e.ScryfallCardPricesPk)
                    .HasName("PK__Scryfall__280AB38DB4BB99F2");

                entity.Property(e => e.ScryfallCardPricesPk).HasColumnName("ScryfallCardPricesPK");

                entity.Property(e => e.Eur).HasMaxLength(20);

                entity.Property(e => e.EurFoil)
                    .HasMaxLength(20)
                    .HasColumnName("Eur_Foil");

                entity.Property(e => e.ScryfallCardFk).HasColumnName("ScryfallCardFK");

                entity.Property(e => e.Tix).HasMaxLength(20);

                entity.Property(e => e.Usd).HasMaxLength(20);

                entity.Property(e => e.UsdEtched)
                    .HasMaxLength(20)
                    .HasColumnName("Usd_Etched");

                entity.Property(e => e.UsdFoil)
                    .HasMaxLength(20)
                    .HasColumnName("Usd_Foil");

                entity.HasOne(d => d.ScryfallCardFkNavigation)
                    .WithMany(p => p.ScryfallCardPrices)
                    .HasForeignKey(d => d.ScryfallCardFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ScryfallC__Scryf__56E8E7AB");
            });

            modelBuilder.Entity<ScryfallCardPurchaseUri>(entity =>
            {
                entity.HasKey(e => e.ScryfallCardPurchaseUrisPk)
                    .HasName("PK__Scryfall__4133D2573C7E5A15");

                entity.Property(e => e.ScryfallCardPurchaseUrisPk).HasColumnName("ScryfallCardPurchaseUrisPK");

                entity.Property(e => e.Cardmarket).HasMaxLength(200);

                entity.Property(e => e.ScryfallCardFk).HasColumnName("ScryfallCardFK");

                entity.Property(e => e.Tcgplayer).HasMaxLength(200);

                entity.HasOne(d => d.ScryfallCardFkNavigation)
                    .WithMany(p => p.ScryfallCardPurchaseUris)
                    .HasForeignKey(d => d.ScryfallCardFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ScryfallC__Scryf__5CA1C101");
            });

            modelBuilder.Entity<ScryfallCardRelatedUri>(entity =>
            {
                entity.HasKey(e => e.ScryfallCardRelatedUrisPk)
                    .HasName("PK__Scryfall__A63F278693DC0795");

                entity.Property(e => e.ScryfallCardRelatedUrisPk).HasColumnName("ScryfallCardRelatedUrisPK");

                entity.Property(e => e.Edhrec).HasMaxLength(200);

                entity.Property(e => e.Gatherer).HasMaxLength(200);

                entity.Property(e => e.ScryfallCardFk).HasColumnName("ScryfallCardFK");

                entity.Property(e => e.TcgplayerInfiniteArticles)
                    .HasMaxLength(200)
                    .HasColumnName("Tcgplayer_Infinite_Articles");

                entity.Property(e => e.TcgplayerInfiniteDecks)
                    .HasMaxLength(200)
                    .HasColumnName("Tcgplayer_Infinite_Decks");

                entity.HasOne(d => d.ScryfallCardFkNavigation)
                    .WithMany(p => p.ScryfallCardRelatedUris)
                    .HasForeignKey(d => d.ScryfallCardFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ScryfallC__Scryf__59C55456");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.UserPk);

                entity.ToTable("User");

                entity.Property(e => e.UserPk).HasColumnName("UserPK");

                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.Password).HasMaxLength(30);

                entity.Property(e => e.Username).HasMaxLength(25);
            });

            modelBuilder.Entity<UserDeck>(entity =>
            {
                entity.HasKey(e => e.UserDeckPk);

                entity.ToTable("UserDeck");

                entity.Property(e => e.UserDeckPk).HasColumnName("UserDeckPK");

                entity.Property(e => e.DeckName).HasMaxLength(50);

                entity.Property(e => e.DeckRuleCriteriaFk).HasColumnName("DeckRuleCriteriaFK");

                entity.Property(e => e.UserFk).HasColumnName("UserFK");

                entity.HasOne(d => d.DeckRuleCriteriaFkNavigation)
                    .WithMany(p => p.UserDecks)
                    .HasForeignKey(d => d.DeckRuleCriteriaFk)
                    .HasConstraintName("FK_UserDeck_DeckRuleCriterion");

                entity.HasOne(d => d.UserFkNavigation)
                    .WithMany(p => p.UserDecks)
                    .HasForeignKey(d => d.UserFk)
                    .HasConstraintName("FK_UserDeck_User");
            });

            modelBuilder.Entity<UserDeckCard>(entity =>
            {
                entity.HasKey(e => e.UserDeckCardPk);

                entity.ToTable("UserDeckCard");

                entity.Property(e => e.UserDeckCardPk).HasColumnName("UserDeckCardPK");

                entity.Property(e => e.DeckLocationFk).HasColumnName("DeckLocationFK");

                entity.Property(e => e.MtgCardFk).HasColumnName("MtgCardFK");

                entity.Property(e => e.UserDeckFk).HasColumnName("UserDeckFK");

                entity.HasOne(d => d.DeckLocationFkNavigation)
                    .WithMany(p => p.UserDeckCards)
                    .HasForeignKey(d => d.DeckLocationFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserDeckCard_DeckLocation");

                entity.HasOne(d => d.MtgCardFkNavigation)
                    .WithMany(p => p.UserDeckCards)
                    .HasForeignKey(d => d.MtgCardFk)
                    .HasConstraintName("FK_UserDeckCard_MtgCard");

                entity.HasOne(d => d.UserDeckFkNavigation)
                    .WithMany(p => p.UserDeckCards)
                    .HasForeignKey(d => d.UserDeckFk)
                    .HasConstraintName("FK_UserDeckCard_UserDeck");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
