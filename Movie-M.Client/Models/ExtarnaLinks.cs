using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movie_M.Client.Models
{
    public class ExtarnaLinks
    {
        public string imDbId { get; set; }
        public string title { get; set; }
        public string fullTitle { get; set; }
        public string type { get; set; }
        public string year { get; set; }
        public string officialWebsite { get; set; }
        public ImDb imDb { get; set; }
        public TheMovieDb theMovieDb { get; set; }
        public RottenTomatoes rottenTomatoes { get; set; }
        public Metacritic metacritic { get; set; }
        public Netflix netflix { get; set; }
        public GooglePlay googlePlay { get; set; }
        public FilmAffinity filmAffinity { get; set; }
        public Freebase freebase { get; set; }
        public Gnd gnd { get; set; }
        public Viaf viaf { get; set; }
        public AlloCine alloCine { get; set; }
        public AllMovie allMovie { get; set; }
        public Port port { get; set; }
        public Dnf dnf { get; set; }
        public MovieMeter movieMeter { get; set; }
        public BoxOfficeMojo boxOfficeMojo { get; set; }
        public Csfd csfd { get; set; }
        public Kinenote kinenote { get; set; }
        public Allcinema allcinema { get; set; }
        public Kinopoisk kinopoisk { get; set; }
        public Elonet elonet { get; set; }
        public LdiF ldiF { get; set; }
        public Cineplex cineplex { get; set; }
        public EDb eDb { get; set; }
        public ElCinema elCinema { get; set; }
        public ScopeDk scope_dk { get; set; }
        public SwedishFilmDatabaseFilm swedishFilmDatabaseFilm { get; set; }
        public ElFilm elFilm { get; set; }
        public OfDb ofDb { get; set; }
        public OpenMediaDatabase openMediaDatabase { get; set; }
        public QuoraTopic quoraTopic { get; set; }
        public CinemaDe cinema_de { get; set; }
        public DeutscheSynchronkartei deutscheSynchronkartei { get; set; }
        public MovieWalker movieWalker { get; set; }
        public object tvGuide { get; set; }
        public FilmwebPl filmweb_pl { get; set; }
        public TVCom tV_com { get; set; }
        public Isan isan { get; set; }
        public Eidr eidr { get; set; }
        public AfiCatalogOfFeature afiCatalogOfFeature { get; set; }
        public TheNumbers theNumbers { get; set; }
        public TcmMovieDatabase tcmMovieDatabase { get; set; }
        public CineGr cine_gr { get; set; }
        public BfiNationalArchive bfiNationalArchive { get; set; }
        public ExploitationVisa exploitationVisa { get; set; }
        public Sratim sratim { get; set; }
        public CineRessources cineRessources { get; set; }
        public CinemathequeQuebecoise cinemathequeQuebecoise { get; set; }
        public EncyclopaediaBritannicaOnline encyclopaediaBritannicaOnline { get; set; }
        public BechdelTestMovieList bechdelTestMovieList { get; set; }
        public MovieplayerIt movieplayer_it { get; set; }
        public MYmovies mYmovies { get; set; }
        public Cinematografo cinematografo { get; set; }
        public Lumiere lumiere { get; set; }
        public Bfi bfi { get; set; }
        public Prisma prisma { get; set; }
        public CineMagia cineMagia { get; set; }
        public Daum daum { get; set; }
        public Douban douban { get; set; }
        public MuseumOfModernArt museumOfModernArt { get; set; }
        public IlMondoDeiDoppiatori ilMondoDeiDoppiatori { get; set; }
        public Fandango fandango { get; set; }
        public MoviepilotDe moviepilot_de { get; set; }
        public SudocAuthorities sudocAuthorities { get; set; }
        public BibliothequeNationaleDeFrance bibliothequeNationaleDeFrance { get; set; }
        public Siamzone siamzone { get; set; }
        public AcademyAwardsDatabase academyAwardsDatabase { get; set; }
        public KnowYourMeme knowYourMeme { get; set; }
        public TheEncyclopediaOfScienceFiction theEncyclopediaOfScienceFiction { get; set; }
        public Letterboxd letterboxd { get; set; }
        public ComicVine comicVine { get; set; }
        public TheTVDB theTVDB { get; set; }
        public object tvSpielfilmSeries { get; set; }
        public List<WikipediaUrl> wikipediaUrls { get; set; } = new List<WikipediaUrl>();
        public string errorMessage { get; set; }
    }

    public class ImDb
    {
        public string id { get; set; }
        public string url { get; set; }
    }

    public class TheMovieDb
    {
        public string id { get; set; }
        public string url { get; set; }
    }

    public class RottenTomatoes
    {
        public string id { get; set; }
        public string url { get; set; }
    }

    public class Metacritic
    {
        public string id { get; set; }
        public string url { get; set; }
    }

    public class Netflix
    {
        public string id { get; set; }
        public string url { get; set; }
    }

    public class GooglePlay
    {
        public string id { get; set; }
        public string url { get; set; }
    }

    public class FilmAffinity
    {
        public string id { get; set; }
        public string url { get; set; }
    }

    public class Freebase
    {
        public string id { get; set; }
        public string url { get; set; }
    }

    public class Gnd
    {
        public string id { get; set; }
        public string url { get; set; }
    }

    public class Viaf
    {
        public string id { get; set; }
        public string url { get; set; }
    }

    public class AlloCine
    {
        public string id { get; set; }
        public string url { get; set; }
    }

    public class AllMovie
    {
        public string id { get; set; }
        public string url { get; set; }
    }

    public class Port
    {
        public string id { get; set; }
        public string url { get; set; }
    }

    public class Dnf
    {
        public string id { get; set; }
        public string url { get; set; }
    }

    public class MovieMeter
    {
        public string id { get; set; }
        public string url { get; set; }
    }

    public class BoxOfficeMojo
    {
        public string id { get; set; }
        public string url { get; set; }
    }

    public class Csfd
    {
        public string id { get; set; }
        public string url { get; set; }
    }

    public class Kinenote
    {
        public string id { get; set; }
        public string url { get; set; }
    }

    public class Allcinema
    {
        public string id { get; set; }
        public string url { get; set; }
    }

    public class Kinopoisk
    {
        public string id { get; set; }
        public string url { get; set; }
    }

    public class Elonet
    {
        public string id { get; set; }
        public string url { get; set; }
    }

    public class LdiF
    {
        public string id { get; set; }
        public string url { get; set; }
    }

    public class Cineplex
    {
        public string id { get; set; }
        public string url { get; set; }
    }

    public class EDb
    {
        public string id { get; set; }
        public string url { get; set; }
    }

    public class ElCinema
    {
        public string id { get; set; }
        public string url { get; set; }
    }

    public class ScopeDk
    {
        public string id { get; set; }
        public string url { get; set; }
    }

    public class SwedishFilmDatabaseFilm
    {
        public string id { get; set; }
        public string url { get; set; }
    }

    public class ElFilm
    {
        public string id { get; set; }
        public string url { get; set; }
    }

    public class OfDb
    {
        public string id { get; set; }
        public string url { get; set; }
    }

    public class OpenMediaDatabase
    {
        public string id { get; set; }
        public string url { get; set; }
    }

    public class QuoraTopic
    {
        public string id { get; set; }
        public string url { get; set; }
    }

    public class CinemaDe
    {
        public string id { get; set; }
        public string url { get; set; }
    }

    public class DeutscheSynchronkartei
    {
        public string id { get; set; }
        public string url { get; set; }
    }

    public class MovieWalker
    {
        public string id { get; set; }
        public string url { get; set; }
    }

    public class FilmwebPl
    {
        public string id { get; set; }
        public string url { get; set; }
    }

    public class TVCom
    {
        public string id { get; set; }
        public string url { get; set; }
    }

    public class Isan
    {
        public string id { get; set; }
        public string url { get; set; }
    }

    public class Eidr
    {
        public string id { get; set; }
        public string url { get; set; }
    }

    public class AfiCatalogOfFeature
    {
        public string id { get; set; }
        public string url { get; set; }
    }

    public class TheNumbers
    {
        public string id { get; set; }
        public string url { get; set; }
    }

    public class TcmMovieDatabase
    {
        public string id { get; set; }
        public string url { get; set; }
    }

    public class CineGr
    {
        public string id { get; set; }
        public string url { get; set; }
    }

    public class BfiNationalArchive
    {
        public string id { get; set; }
        public string url { get; set; }
    }

    public class ExploitationVisa
    {
        public string id { get; set; }
        public string url { get; set; }
    }

    public class Sratim
    {
        public string id { get; set; }
        public string url { get; set; }
    }

    public class CineRessources
    {
        public string id { get; set; }
        public string url { get; set; }
    }

    public class CinemathequeQuebecoise
    {
        public string id { get; set; }
        public string url { get; set; }
    }

    public class EncyclopaediaBritannicaOnline
    {
        public string id { get; set; }
        public string url { get; set; }
    }

    public class BechdelTestMovieList
    {
        public string id { get; set; }
        public string url { get; set; }
    }

    public class MovieplayerIt
    {
        public string id { get; set; }
        public string url { get; set; }
    }

    public class MYmovies
    {
        public string id { get; set; }
        public string url { get; set; }
    }

    public class Cinematografo
    {
        public string id { get; set; }
        public string url { get; set; }
    }

    public class Lumiere
    {
        public string id { get; set; }
        public string url { get; set; }
    }

    public class Bfi
    {
        public string id { get; set; }
        public string url { get; set; }
    }

    public class Prisma
    {
        public string id { get; set; }
        public string url { get; set; }
    }

    public class CineMagia
    {
        public string id { get; set; }
        public string url { get; set; }
    }

    public class Daum
    {
        public string id { get; set; }
        public string url { get; set; }
    }

    public class Douban
    {
        public string id { get; set; }
        public string url { get; set; }
    }

    public class MuseumOfModernArt
    {
        public string id { get; set; }
        public string url { get; set; }
    }

    public class IlMondoDeiDoppiatori
    {
        public string id { get; set; }
        public string url { get; set; }
    }

    public class Fandango
    {
        public string id { get; set; }
        public string url { get; set; }
    }

    public class MoviepilotDe
    {
        public string id { get; set; }
        public string url { get; set; }
    }

    public class SudocAuthorities
    {
        public string id { get; set; }
        public string url { get; set; }
    }

    public class BibliothequeNationaleDeFrance
    {
        public string id { get; set; }
        public string url { get; set; }
    }

    public class Siamzone
    {
        public string id { get; set; }
        public string url { get; set; }
    }

    public class AcademyAwardsDatabase
    {
        public string id { get; set; }
        public string url { get; set; }
    }

    public class KnowYourMeme
    {
        public string id { get; set; }
        public string url { get; set; }
    }

    public class TheEncyclopediaOfScienceFiction
    {
        public string id { get; set; }
        public string url { get; set; }
    }

    public class Letterboxd
    {
        public string id { get; set; }
        public string url { get; set; }
    }

    public class ComicVine
    {
        public string id { get; set; }
        public string url { get; set; }
    }

    public class TheTVDB
    {
        public string id { get; set; }
        public string url { get; set; }
    }

    public class WikipediaUrl
    {
        public string language { get; set; }
        public string title { get; set; }
        public string url { get; set; }
    }



}
