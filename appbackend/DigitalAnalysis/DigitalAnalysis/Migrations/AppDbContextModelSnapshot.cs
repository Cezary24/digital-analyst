﻿// <auto-generated />
using System;
using DigitalAnalysis.Configures;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DigitalAnalysis.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("DigitalAnalysis.Models.Netflix.NetflixFilm", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("text")
                        .HasColumnName("show_id");

                    b.Property<string>("Casts")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("casts");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("country");

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("date_added");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("director");

                    b.Property<string>("Duration")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("duration");

                    b.Property<string>("ListedIn")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("listed_in");

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("rating");

                    b.Property<string>("ReleaseYear")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("release_year");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("title");

                    b.HasKey("Id");

                    b.ToTable("netflix_films");
                });

            modelBuilder.Entity("DigitalAnalysis.Models.Netflix.NetflixOrginalsShow", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Genre");

                    b.Property<double>("ImdbScore")
                        .HasColumnType("double precision")
                        .HasColumnName("IMDB_Score");

                    b.Property<string>("Language")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Language");

                    b.Property<DateTime>("Premiere")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("Premiere");

                    b.Property<int>("Runtime")
                        .HasColumnType("integer")
                        .HasColumnName("Runtime");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Title");

                    b.HasKey("Id");

                    b.ToTable("netflix_originals_shows");
                });

            modelBuilder.Entity("DigitalAnalysis.Models.Netflix.NetflixRevenue", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<long?>("ApacMembers")
                        .HasColumnType("bigint")
                        .HasColumnName("APAC_Members");

                    b.Property<long?>("ApacRevenue")
                        .HasColumnType("bigint")
                        .HasColumnName("APAC_Revenue");

                    b.Property<double?>("ApacRpu")
                        .HasColumnType("double precision")
                        .HasColumnName("APAC_RPU");

                    b.Property<DateTime?>("Date")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("Date");

                    b.Property<int?>("DomesticFreeTrialers")
                        .HasColumnType("integer")
                        .HasColumnName("Domestic_Free_Trialers");

                    b.Property<int?>("DomesticMembers")
                        .HasColumnType("integer")
                        .HasColumnName("Domestic_Members");

                    b.Property<int?>("DomesticRevenue")
                        .HasColumnType("integer")
                        .HasColumnName("Domestic_Revenue");

                    b.Property<long?>("EmeaMembers")
                        .HasColumnType("bigint")
                        .HasColumnName("EMEA_Members");

                    b.Property<long?>("EmeaRevenue")
                        .HasColumnType("bigint")
                        .HasColumnName("EMEA_Revenue");

                    b.Property<double?>("EmeaRpu")
                        .HasColumnType("double precision")
                        .HasColumnName("EMEA_RPU");

                    b.Property<long?>("GlobalRevenue")
                        .HasColumnType("bigint")
                        .HasColumnName("Global_Revenue");

                    b.Property<int?>("InternationalMembers")
                        .HasColumnType("integer")
                        .HasColumnName("International_Members");

                    b.Property<int?>("InternationalRevenue")
                        .HasColumnType("integer")
                        .HasColumnName("International_Revenue");

                    b.Property<int?>("InterntaionalFreeTrialers")
                        .HasColumnType("integer")
                        .HasColumnName("Interntaional_Free_Trialers");

                    b.Property<long?>("LatmMembers")
                        .HasColumnType("bigint")
                        .HasColumnName("LATM_Members");

                    b.Property<long?>("LatmRevenue")
                        .HasColumnType("bigint")
                        .HasColumnName("LATM_Revenue");

                    b.Property<double?>("LatmRpu")
                        .HasColumnType("double precision")
                        .HasColumnName("LATM_RPU");

                    b.Property<int?>("NetflixGlobalUsers")
                        .HasColumnType("integer")
                        .HasColumnName("Netflix_Global_Users");

                    b.Property<long?>("UacnMembers")
                        .HasColumnType("bigint")
                        .HasColumnName("UACN_Members");

                    b.Property<long?>("UacnRevenue")
                        .HasColumnType("bigint")
                        .HasColumnName("UACN_Revenue");

                    b.Property<double?>("UacnRpu")
                        .HasColumnType("double precision")
                        .HasColumnName("UACN_RPU");

                    b.HasKey("Id");

                    b.ToTable("netflix_revenue");
                });

            modelBuilder.Entity("DigitalAnalysis.Models.Netflix.NetflixRevenueQuarter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Area")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Area");

                    b.Property<long>("Q1_2018")
                        .HasColumnType("bigint")
                        .HasColumnName("Q1_2018");

                    b.Property<long>("Q1_2019")
                        .HasColumnType("bigint")
                        .HasColumnName("Q1_2019");

                    b.Property<long>("Q1_2020")
                        .HasColumnType("bigint")
                        .HasColumnName("Q1_2020");

                    b.Property<long>("Q2_2018")
                        .HasColumnType("bigint")
                        .HasColumnName("Q2_2018");

                    b.Property<long>("Q2_2019")
                        .HasColumnType("bigint")
                        .HasColumnName("Q2_2019");

                    b.Property<long>("Q2_2020")
                        .HasColumnType("bigint")
                        .HasColumnName("Q2_2020");

                    b.Property<long>("Q3_2018")
                        .HasColumnType("bigint")
                        .HasColumnName("Q3_2018");

                    b.Property<long>("Q3_2019")
                        .HasColumnType("bigint")
                        .HasColumnName("Q3_2019");

                    b.Property<long>("Q4_2018")
                        .HasColumnType("bigint")
                        .HasColumnName("Q4_2018");

                    b.Property<long>("Q4_2019")
                        .HasColumnType("bigint")
                        .HasColumnName("Q4_2019");

                    b.HasKey("Id");

                    b.ToTable("netflix_revenue_2018_2020");
                });

            modelBuilder.Entity("DigitalAnalysis.Models.Netflix.NetflixStockPrice", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("text")
                        .HasColumnName("show_id");

                    b.Property<double>("AdjClose")
                        .HasColumnType("double precision")
                        .HasColumnName("Adj_Close");

                    b.Property<double>("Close")
                        .HasColumnType("double precision")
                        .HasColumnName("Close");

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("Date");

                    b.Property<double>("High")
                        .HasColumnType("double precision")
                        .HasColumnName("High");

                    b.Property<double>("Low")
                        .HasColumnType("double precision")
                        .HasColumnName("Low");

                    b.Property<double>("Open")
                        .HasColumnType("double precision")
                        .HasColumnName("Open");

                    b.Property<int>("Volume")
                        .HasColumnType("integer")
                        .HasColumnName("Volume");

                    b.HasKey("Id");

                    b.ToTable("netflix_stock_prices");
                });

            modelBuilder.Entity("DigitalAnalysis.Models.Netflix.NetflixSubscription", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Area")
                        .HasColumnType("text")
                        .HasColumnName("Area");

                    b.Property<int?>("Subscribers")
                        .HasColumnType("integer")
                        .HasColumnName("Subscribers");

                    b.Property<string>("Years")
                        .HasColumnType("text")
                        .HasColumnName("Years");

                    b.HasKey("Id");

                    b.ToTable("netflix_subscription_2020");
                });

            modelBuilder.Entity("DigitalAnalysis.Models.Netflix.NetflixSubscriptionFee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<double?>("CostPerMonthBasic")
                        .HasColumnType("double precision")
                        .HasColumnName("Cost_Per_Month_Basic");

                    b.Property<double?>("CostPerMonthDtandard")
                        .HasColumnType("double precision")
                        .HasColumnName("Cost_Per_Month_Standard");

                    b.Property<double?>("CostPerMonthPremium")
                        .HasColumnType("double precision")
                        .HasColumnName("Cost_Per_Month_Premium");

                    b.Property<string>("Country")
                        .HasColumnType("text")
                        .HasColumnName("Country");

                    b.Property<string>("CountryCode")
                        .HasColumnType("text")
                        .HasColumnName("Country_Code");

                    b.Property<int?>("NumberOfMovies")
                        .HasColumnType("integer")
                        .HasColumnName("Number_of_Movies");

                    b.Property<int?>("NumberOfTVShows")
                        .HasColumnType("integer")
                        .HasColumnName("Number_of_TV_Shows");

                    b.Property<int?>("TotalLibrarySize")
                        .HasColumnType("integer")
                        .HasColumnName("Total_Library_Size");

                    b.HasKey("Id");

                    b.ToTable("netflix_subscription_fee_dec_2021");
                });

            modelBuilder.Entity("DigitalAnalysis.Models.Netflix.NetflixTitle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Casts")
                        .HasColumnType("text")
                        .HasColumnName("casts");

                    b.Property<string>("Country")
                        .HasColumnType("text")
                        .HasColumnName("country");

                    b.Property<DateTime?>("DateAdded")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("date_added");

                    b.Property<string>("Description")
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<string>("Director")
                        .HasColumnType("text")
                        .HasColumnName("director");

                    b.Property<string>("Duration")
                        .HasColumnType("text")
                        .HasColumnName("duration");

                    b.Property<string>("ListedIn")
                        .HasColumnType("text")
                        .HasColumnName("listed_in");

                    b.Property<string>("Rating")
                        .HasColumnType("text")
                        .HasColumnName("rating");

                    b.Property<string>("ReleaseYear")
                        .HasColumnType("text")
                        .HasColumnName("release_year");

                    b.Property<string>("Title")
                        .HasColumnType("text")
                        .HasColumnName("title");

                    b.Property<string>("Type")
                        .HasColumnType("text")
                        .HasColumnName("type");

                    b.HasKey("Id");

                    b.ToTable("netflix_titles");
                });

            modelBuilder.Entity("DigitalAnalysis.Models.Netflix.NetflixTvShow", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<double?>("IMDBRating")
                        .HasColumnType("double precision")
                        .HasColumnName("IMDB_Rating");

                    b.Property<bool?>("Netflix")
                        .HasColumnType("boolean")
                        .HasColumnName("Netflix");

                    b.Property<string>("Rating")
                        .HasColumnType("text")
                        .HasColumnName("Rating");

                    b.Property<string>("Title")
                        .HasColumnType("text")
                        .HasColumnName("Titles");

                    b.Property<DateTime?>("Year")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("Year");

                    b.HasKey("Id");

                    b.ToTable("netflix_tv_shows");
                });
#pragma warning restore 612, 618
        }
    }
}
