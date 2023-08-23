using ScreenSound_OO;

Musica musica1 = new Musica();
musica1.nome = "Roxanne";
musica1.artista = "The Police";
musica1.duracao = 273;
musica1.disponivel = true; //Esse atributo usa Setter

Musica musica2 = new Musica();
musica2.nome = "Vertigo";
musica2.artista = "U2";
musica2.duracao = 324;
musica2.disponivel = true;

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
