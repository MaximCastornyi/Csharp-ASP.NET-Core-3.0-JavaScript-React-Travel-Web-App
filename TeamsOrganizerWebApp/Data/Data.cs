using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamsOrganizerWebApp.Data.Models;

namespace TeamsOrganizerWebApp.Data
{
    public static class Data
    {
        public static List<Trip> Trips => allTrips;
        static List<Trip> allTrips = new List<Trip>()
    {
        new Trip()
        {
            Id=1,
            Name="Hamburg, DE",
            Description="Hamburg amtlich Freie und Hansestadt Hamburg (niederdeutsch Friee un Hansestadt Hamborg, Ländercode: HH), ist als Stadtstaat ein Land der Bundesrepublik Deutschland. Der amtliche Name verweist auf die Geschichte Hamburgs als Freie Reichsstadt und als führendes Mitglied des Handelsbundes der Hanse.",
            DateStarted = new DateTime(2020,02,25),
            DateCompleted = new DateTime(2020,03,1)
        },
        new Trip()
        {
            Id=2,
            Name="Dresden, DE",
            Description="Dresden ist die Landeshauptstadt des Freistaates Sachsen. Mit rund 557.000 Einwohnern (November 2019[2]) ist Dresden, nach Leipzig, die zweitgrößte sächsische Kommune, zweitgrößte Stadt in den Neuen Bundesländern und die zwölftgrößte Stadt Deutschlands.",
            DateStarted = new DateTime(2020,02,25),
            DateCompleted = new DateTime(2020,03,1)
        },
        new Trip()
        {
            Id=3,
            Name="Leipzig, DE",
            Description="Leipzig ist eine kreisfreie Stadt sowie mit 587.857 Einwohnern (31. Dezember 2018) die größte Stadt im Freistaat Sachsen und belegte 2018 in der Liste der Großstädte in Deutschland den achten Platz. Für Mitteldeutschland ist sie ein historisches Zentrum der Wirtschaft, des Handels und Verkehrs, der Verwaltung, Kultur und Bildung sowie für die „Kreativszene“.",
            DateStarted = new DateTime(2020,02,25),
            DateCompleted = new DateTime(2020,03,1)
        },
        new Trip()
        {
            Id=4,
            Name="Hannover, DE",
            Description="Hannover ist die Hauptstadt des Landes Niedersachsen. Der am Südrand des Norddeutschen Tieflandes an der Leine und der Ihme gelegene Ort wurde 1150 erstmals erwähnt und erhielt 1241 das Stadtrecht. Hannover war ab 1636 welfische Residenzstadt, ab 1692 Residenz Kurhannovers, ab 1814 Hauptstadt des Königreichs Hannover, nach dessen Annexion durch Preußen ab 1866 Provinzhauptstadt der Provinz Hannover, nach Auflösung Preußens im August 1946 Hauptstadt des Landes Hannover und nach dessen Fusion mit den Freistaaten Braunschweig, Oldenburg und Schaumburg-Lippe im November 1946 niedersächsische Landeshauptstadt. Seit 1875 Großstadt, zählt Hannover heute mit 538.068 Einwohnern (Ende 2018) zu den 15 einwohnerreichsten Städten Deutschlands.",
            DateStarted = new DateTime(2020,02,25),
            DateCompleted = new DateTime(2020,03,1)
        },
        new Trip()
        {
            Id=5,
            Name="Bonn, DE",
            Description="Die Bundesstadt Bonn ist eine kreisfreie Großstadt im Regierungsbezirk Köln im Süden des Landes Nordrhein-Westfalen. Mit 327.258 Einwohnern (Stand 31. Dezember 2018) zählt Bonn zu den zwanzig größten Städten Deutschlands. Bonn gehört zu den Metropolregionen Rheinland und Rhein-Ruhr sowie zur Region Köln/Bonn. Die Stadt an beiden Ufern des Rheins war von 1949 bis 1990 Bundeshauptstadt und bis 1999 Regierungssitz der Bundesrepublik Deutschland,[2] seither ist Bonn nur noch faktischer zweiter Regierungssitz Deutschlands.",
            DateStarted = new DateTime(2020,02,25),
            DateCompleted = new DateTime(2020,03,1)
        },
        new Trip()
        {
            Id=7,
            Name="Berlin, DE",
            Description="Berlin ist die Hauptstadt der Bundesrepublik Deutschland und zugleich eines ihrer Länder.[14] Die Stadt ist mit rund 3,6 Millionen Einwohnern die bevölkerungsreichste und mit 892 Quadratkilometern auch die flächengrößte Gemeinde Deutschlands. Außerdem ist sie damit die einwohnerstärkste Stadt der Europäischen Union.[4] Sie bildet das Zentrum der Agglomeration Berlin mit rund 4,5 Millionen und der Metropolregion Berlin/Brandenburg mit rund 6 Millionen Einwohnern. Der Stadtstaat besteht aus zwölf Bezirken. Neben den Flüssen Spree und Havel befinden sich im Stadtgebiet kleinere Fließgewässer sowie zahlreiche Seen und Wälder.",
            DateStarted = new DateTime(2020,03,11),
            DateCompleted = new DateTime(2020,03,1)
        }
    };

    }
}