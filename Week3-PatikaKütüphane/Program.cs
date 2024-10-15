using Week3_PatikaKütüphane;

Books book1 = new Books("Aylin", "Ayşe","Kulin", 398, "Remzi Kitabevi");

Console.WriteLine($"Kitap Adı: {book1.BookName}, Yazar: {book1.AuthorName} {book1.AuthorSurname}, Sayfa Sayısı: {book1.PageNumber}, Yayınevi: {book1.PublishingHouse}, Kayıt Tarihi: {book1.RegistrationDate}");

Books book2 = new Books("Ben yazdim", "Ezgi","Gecimli", 158, "Gecimli Kitabevi");

Console.WriteLine($"Kitap Adı: {book2.BookName}, Yazar: {book2.AuthorName} {book2.AuthorSurname}, Sayfa Sayısı: {book2.PageNumber}, Yayınevi: {book2.PublishingHouse}, Kayıt Tarihi: {book2.RegistrationDate}");

Console.ReadKey();