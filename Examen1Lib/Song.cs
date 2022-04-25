namespace Examen1Lib;

public class Song
{
    // === Variable declaration ===
    private string _title;
    private string _artist;
    private int _second;
    private double _minute;

    // === Parameter declaration ===
    public static int NextId { get; private set; } = 1;

    public int Id { get; private set; }

    public string Title
    {
        get => _title;
        set
        {
            if (value.Length < 1)
            {
                throw new ArgumentException("The lenght of the title must be at least one character long");
            }

            _title = value;
        }
    }

    public string Artist
    {
        get => _artist;
        set
        {
            if (value.Length < 1)
            {
                throw new ArgumentException("The lenght of the title must be at least three character long");
            }

            _artist = value;
        }
    }

    public int Second
    {
        get => _second;
        set
        {
            if (value < 2)
            {
                throw new ArgumentException("The lenght of the song must be at least more than 1 second");
            }

            _second = value;
        }
    }

    public double Minute
    {
        get => _minute;

        set
        {
            double tmpSecond = Second % 60;
            double tmpMinute = Second / 60;

            _minute = (tmpSecond / 100) + tmpMinute;
        }
    }

    // === Constructor ===
    public Song(string title, string artist, int second)
    {
        Id = NextId;
        NextId++;
        Title = title;
        Artist = artist;
        Second = second;
        Minute = Second;
    }

// === Override ===
    public override bool Equals(object? obj)
    {
        if (obj == null || this.GetType() != obj.GetType())
        {
            return false;
        }

        Song other = (Song) obj;
        // return Name.Equals(other.Name) && Dob.Equals(other.Dob);
        return Id == other.Id;
    }

    public override string ToString()
    {
        int tmpSecond = Second % 60;
        int tmpMinute = Second / 60;
        TimeSpan totalTime = new TimeSpan(0, tmpMinute, tmpSecond);
        string formattedTimeSpan = string.Format("{0:D2}:{1:D2}", totalTime.Minutes, totalTime.Seconds);


        return $"{Id}: {Title} ({Artist}) {formattedTimeSpan}";
    }
}