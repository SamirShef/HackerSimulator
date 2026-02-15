class Date
{
    public short Year { get => _year; }
    public byte Mounth { get => _mounth; }
    public byte Day { get => _day; }
    public byte Hour { get => _hour; }
    public byte Min { get => _min; }
    public byte Sec { get => _sec; }

    private readonly short _year;
    private readonly byte _mounth;
    private readonly byte _day;
    private readonly byte _hour;
    private readonly byte _min;
    private readonly byte _sec;

    public Date(short year, byte mounth, byte day, byte hour, byte min, byte sec)
    {
        _year = year;
        _mounth = mounth;
        _day = day;
        _hour = hour;
        _min = min;
        _sec = sec;
    }

    public override string ToString()
    {
        return $"{_year}.{_mounth}.{_day} {_hour}:{_min}:{_sec}";
    }
}