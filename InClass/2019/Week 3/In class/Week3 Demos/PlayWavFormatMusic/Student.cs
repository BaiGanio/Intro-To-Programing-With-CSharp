namespace PlayWavFormatMusic
{
    public class Student
    {
        public string Name { get; set; }

        public string University { get; set; }

        public long FacultyNumber { get; set; }

        public bool IsGraduated { get; set; }

        public double OverallScore { get; set; }

        public string Introduce()
        {
            return
                $"Hello, I'm {this.Name}. " +
                $"\nAnd I study in {this.University} university! " +
                $"\nFaculty number: {this.FacultyNumber} " +
                $"\nIs graduated: { this.IsGraduated} " +
                $"\nOverall score: % {this.OverallScore}";
        }
    }
}
