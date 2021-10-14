namespace GymHipertrofit
{
    internal class Paragraph
    {
        public Paragraph(string v)
        {
        }

        public Paragraph(object text, object boldFont)
        {
            Text = text;
            BoldFont = boldFont;
        }

        public object Text { get; }
        public object BoldFont { get; }
    }
}