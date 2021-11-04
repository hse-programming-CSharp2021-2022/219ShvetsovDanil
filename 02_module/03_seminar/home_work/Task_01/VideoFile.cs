namespace Task_01
{
    public class VideoFile
    {
        // Declaration of private fields.
        private string _name;
        private int _duration;
        private int _quality;

        // Constructor.
        public VideoFile(string name, int duration, int quality)
        {
            _name = name;
            _duration = duration;
            _quality = quality;
        }

        // Property of size of video file.
        public int Size => _duration * _quality;

        // Method which returns info string about video file.
        public string GetInfo() => 
            $"Информация о видеофайле {_name}:\n" +
            $"Длительность в секундах: {_duration}\n" +
            $"Качество видеофайла: {_quality}\n" +
            $"Размер видеофайла: {Size}";
    }
}