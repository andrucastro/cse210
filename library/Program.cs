Book book1 = new Book();
book1.SetAuthor("smith");
book1.SetTitle("A Great Book");

Console.WriteLine(book1.GetBookInfo());

PictureBook book2 = new PictureBook();
book2.SetAuthor("andres");
book2.SetTitle("chocho aventuras");
book2.SetIllustrator("takeshi obata");

Console.WriteLine(book2.GetPictureInformation());
