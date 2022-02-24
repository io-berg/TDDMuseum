using System.Collections.Generic;
using src;
using Xunit;

namespace test;

public class UnitTest1
{
// Programmet går att starta och använda via konsollen
// Användaren kan via programmets gränsnitt lista alla rum
[Fact]
public void TestThatUserCanGetAllMuseumRooms()
{
    // Given
    var expected = 2;
    var museum = new Museum("Museum");
    museum.AddRoom(new Room("room1"));
    museum.AddRoom(new Room("room2"));

    // When
    var numberOfRooms = museum.GetRooms().Count;

    // Then
    Assert.Equal(expected, numberOfRooms);
}

// Användaren kan via programmets gränsnitt lista alla konstverken som finns i ett specifikt rum.
[Fact]
public void TestThatUserCanGetAllArtworkInARoom()
{
    // Given
    var expected = 3;
    var room = new Room("testroom");
    var artWork1 = new Artwork("test1", "tes", "tess");
    var artWork2 = new Artwork("test1", "tes", "tess");
    var artWork3 = new Artwork("t432st1", "tes", "tess");
    room.AddArtwork(artWork1);
    room.AddArtwork(artWork2);
    room.AddArtwork(artWork3);

    // When
    var actualNumberOfArtworks = room.GetArtwork().Count;

    // Then
    Assert.Equal(expected, actualNumberOfArtworks);
}


// Användaren kan via programmets gränsnitt lägga till ett nytt konstverk i ett rum.
// Användaren kan via programmets gränsnitt radera ett specifikt konstverk från ett rum.
// Användaren kan via programmets gränsnitt lägga till ett helt nytt rum i museet.
// Användaren kan via programmets gränsnitt radera ett specifikt rum i museet.
// Varje konstverk representeras alltid för användaren via en titel, beskrivning och en upphovsmakare.
// Endast 3 konstverk kan finnas i varje rum samtidigt.
// Ett rum kan inte raderas om det finns konstverk i rummet.
[Fact]
public void TestThatARoomCantBeDeletedIfItConainsArtWork()
{
    // Given
    var expected = 1;
    var museum = new Museum("museum");
    var room = new Room("room");
    room.AddArtwork(new Artwork("213", "123", "123"));

    // When
    museum.DeleteRoom(room);
    var remainingRooms = museum.GetRooms().Count;

    // Then
    Assert.Equal(expected, remainingRooms);
}

// Användaren kan via programmets gränsnitt skapa ett helt nytt museum/byggnad samt växla mellan vilket museeum som är det aktiva för tillfället.

}