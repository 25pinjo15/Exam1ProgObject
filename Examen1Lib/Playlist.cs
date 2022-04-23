namespace Examen1Lib;

public class Playlist
{
    // ---- Variable declaration ----
    private string _name;
    private int _numberOfSong;
    

    // ---- Parameter declaration -----
    public static int NextId { get; private set; } = 1;

    public int Id { get; private set; }

    public string Name
    {
        get => _name;
        set
        {
            if (value.Length < 1)
            {
                throw new ArgumentException("The lenght of the playlist must be at least one character long");
            }

            _name = value;
        }
    }

    public int Count
    {
        get
        {
            _numberOfSong = Songlist.Count;
            return _numberOfSong;
        }
        
    }
    
    public int TotalLenght
    {
        get
        {
            int tmp = 0;
            foreach (Song song in Songlist)
            {

                tmp += song.Second;
            }
            return tmp;
        }
       
    }
    public List<Song> Songlist = new List<Song>();

    // ---- Constructor ----
    public Playlist(string name)
    {
        Id = NextId;
        NextId++;
        Name = name;
        List<Song> songlist = Songlist;
        
    }

// ---- Override ----
    public override bool Equals(object? obj)
    {
        if (obj == null || this.GetType() != obj.GetType())
        {
            return false;
        }

        Playlist other = (Playlist) obj;
        // return Name.Equals(other.Name) && Dob.Equals(other.Dob);
        return Id == other.Id;
    }

    public override string ToString()
    {
        string tmp2 = "";
        if (Songlist.Count > 0)
        {
            foreach (Song song in Songlist)
            {
                
                tmp2 = tmp2 + ($"{song}\n");
                //return tmp;
            }
        }
        else
        {
            return "empty";
        }

        return tmp2;
    }
}