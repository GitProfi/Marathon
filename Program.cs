using Marathon;

Liste pinzgauerLandeslauf = new("Pinzgauer Landeslauf am 16.01.2024");
pinzgauerLandeslauf.AddTeilnehmer(new Teilnehmer("Leon", "Reitenbach", 99, 124));
pinzgauerLandeslauf.AddTeilnehmer(new Teilnehmer("Max", "Verstappen", 33, 12));
pinzgauerLandeslauf.AddTeilnehmer(new Teilnehmer("Philipp", "Pontasch", 69, 2880));


pinzgauerLandeslauf.Print();