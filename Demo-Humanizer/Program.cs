using Humanizer;
using Humanizer.Bytes;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Demo_Humanizer
{
    

    class Program
    {

        static void Main(string[] args)
        {
            // 1. Chuyển tên hàm, tên biến thành chuỗi có nghĩa
            Console.WriteLine("PascalCaseInputStringIsTurnedIntoSentence".Humanize());
            Console.WriteLine("Underscored_input_string_is_turned_into_sentence".Humanize());
            Console.WriteLine("Underscored_input_String_is_turned_INTO_sentence".Humanize());
            Console.WriteLine("some title".Pascalize());
            Console.WriteLine("some title".Camelize());
            Console.WriteLine("some title".Underscore());
            Console.WriteLine("Sentence casing".Transform(To.LowerCase));
            Console.WriteLine("Sentence casing".Transform(To.SentenceCase));
            Console.WriteLine("Sentence casing".Transform(To.TitleCase));
            Console.WriteLine("Sentence casing".Transform(To.UpperCase));

            // 2. Thu gọn chuỗi
            Console.WriteLine("Long text to truncate".Truncate(10, Truncator.FixedLength)); // cắt 10 ký tự
            Console.WriteLine("Long text to truncate".Truncate(2, Truncator.FixedNumberOfWords)); // cắt 2 từ

            // 4. Xử lý DateTime
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("vi-VN");
            Console.WriteLine(DateTime.UtcNow.AddHours(-20).Humanize());
            Console.WriteLine(DateTime.UtcNow.AddHours(-60).Humanize());
            Console.WriteLine(DateTime.UtcNow.AddHours(2).Humanize());
            Console.WriteLine(DateTime.UtcNow.AddDays(1).Humanize());

            // 5. Xử lý TimeSpan
            Console.WriteLine(TimeSpan.FromMilliseconds(2).Humanize());
            Console.WriteLine(TimeSpan.FromDays(1).Humanize());
            Console.WriteLine(TimeSpan.FromDays(16).Humanize());
            Console.WriteLine(TimeSpan.FromMilliseconds(1299630020).Humanize());
            Console.WriteLine(TimeSpan.FromMilliseconds(1299630020).Humanize(3));
            Console.WriteLine(TimeSpan.FromMilliseconds(1299630020).Humanize(4));

            // 6. Chuyển số thành chữ (chỉ tiếng Anh)
            Console.WriteLine(1.ToWords());
            Console.WriteLine(10.ToWords());
            Console.WriteLine(11.ToWords());
            Console.WriteLine(122.ToWords());
            Console.WriteLine(4501.ToWords());

            // 7. Xử lý file size
            var fileSize = (10).Kilobytes();

            Console.WriteLine(fileSize.Bits);
            Console.WriteLine(fileSize.Bytes);
            Console.WriteLine(fileSize.Kilobytes);

            var total = (10).Gigabytes() + (512).Megabytes() - (2.5).Gigabytes();
            Console.WriteLine(total);
            Console.WriteLine(7.Bits().ToString());
            Console.WriteLine(ByteSize.Parse("1.55 mB"));
            Console.WriteLine(ByteSize.Parse("1.55 mb"));
            Console.WriteLine(ByteSize.Parse("1.55 GB"));
            Console.WriteLine(ByteSize.Parse("1.55 gB"));
            Console.WriteLine(ByteSize.Parse("1.55 gb"));
            Console.WriteLine(ByteSize.Parse("1.55 TB"));

            Console.ReadLine();
        }
    }
}
