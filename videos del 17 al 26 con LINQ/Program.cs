LinqQueries queries = new LinqQueries();

//Toda la coleccion
//ImprimirValores(queries.TodaLaColeccion());

//Libros despues del 2000
//ImprimirValores(queries.LibrosDespuesdel2000());

//Libros que tienen mas de 250 pags y tienen en el titulo la palabra in action
//ImprimirValores(queries.LibrosConMasde250PagConPalabrasInAction());

//Todos los libros tienen Status
//Console.WriteLine($" Todos los libros tienen status? - {queries.TodosLosLibrosTienenStatus()}");

//Si algun libro fue publicado en 2005
//Console.WriteLine($" Algun libro fue publicado en 2005? - {queries.SiAlgunLibroFuePublicado2005()}");


//Libros de python
//ImprimirValores(queries.LibrosdePython());

//libros de Java ordenados por nombre
//ImprimirValores(queries.LibrosdeJavaPorNombreAscendente());

//libros que tienen mas de 450 paginas ordernados por cantidad de paginas
//ImprimirValores(queries.Librosmasde450pagOrdernadorPorNumPagDescendente());

//los 3  libros de Java publicados recientemente
//ImprimirValores(queries.TresPrimerosLibrosJavaOrdenadosPorFecha());

//tercer y caurto libro con mas de 400 paginas
//ImprimirValores(queries.TerceryCuartoLibroDeMas400Pag());

//tres primeros libros filtrados con Select
//ImprimirValores(queries.TresPrimeroLibrosDeLaCollecion());

//Cantidad de lirbos entre 200 y 500pag
//(queries.CantidadDeLibrosEntre200y500Pag());

//Libros mayor
//ImprimirValores(queries.NumeroDePagLibroMayor());

//libros publicados despues del 2015
//Console.WriteLine(queries.TitulosDeLibrosDespuesDel2015Concatenados());

//Fecha de publicacion menos
//ImprimirValores(queries.FechadePublicacionMenos());

//var LibroFechaPubReciente = querie.LibroConFechaPublicacionMasReciente();
//Console.WriteLine($"{LibroFechaPubReciente.Title} - {LibroFechaPubReciente.PublishedDate.ToShortDateString()}");

//Libros publicados a partir del 2000 agrupados por ano
//ImprimirGrupo(queries.LibrosDespuesdel2000AgrupadosporAno());

//Diccionario de libros agrupados por primera letra del titulo
//var diccionarioLookup = queries.DiccionariosDeLibrosPorLetra();
//ImprimirDiccionario(diccionarioLookup, 'Z');

// libros filtradaor con la clausula join 
//ImprimirValores(queries.LibrosDespuesdel2005conmasde500Pags());

 Console.WriteLine("\nrepositorio (usando GroupBy)\n");
        var reporte1 = queries.ReporteCategorias_GroupBy();
        ImprimirReporte(reporte1);

        // --- Reporte usando Aggregate ---
        Console.WriteLine("\n repositorio  (usando Aggregate)\n");
        var reporte2 = queries.ReporteCategorias_Aggregate();
        ImprimirReporte(reporte2);

void ImprimirValores(IEnumerable<Book> listadelibros)
{
    Console.WriteLine("{0,-60} {1, 15} {2, 15}\n", "Titulo", "N. Paginas", "Fecha publicacion");
    foreach(var item in listadelibros)
    {
        Console.WriteLine("{0,-60} {1, 15} {2, 15}", item.Title, item.PageCount, item.PublishedDate.ToShortDateString());
    }
}

void ImprimirGrupo(IEnumerable<IGrouping<int,Book>> ListadeLibros)
{
    foreach(var grupo in ListadeLibros)
    {
        Console.WriteLine("");
        Console.WriteLine($"Grupo: { grupo.Key }");
        Console.WriteLine("{0,-60} {1, 15} {2, 15}\n", "Titulo", "N. Paginas", "Fecha publicacion");
        foreach(var item in grupo)
        {
            Console.WriteLine("{0,-60} {1, 15} {2, 15}",item.Title,item.PageCount,item.PublishedDate.Date.ToShortDateString()); 
        }
    }
}

void ImprimirDiccionario(ILookup<char, Book> ListadeLibros, char letra)
{
   Console.WriteLine("{0,-60} {1, 15} {2, 15}\n", "Titulo", "N. Paginas", "Fecha publicacion");
   foreach(var item in ListadeLibros[letra])
   {
         Console.WriteLine("{0,-60} {1, 15} {2, 15}",item.Title,item.PageCount,item.PublishedDate.Date.ToShortDateString()); 
   }
}