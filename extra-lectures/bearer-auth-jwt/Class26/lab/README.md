# Lab 26: Building a Playlist

You are tasked to create an API that will hold individual user's playlist of songs. 

The songs they can pick from can come from

1. A prebuilt library
2. Custom created

The app will allow for users to:

1. Register and Sign in
2. Create personal playlists
3. Add songs to each playlist
4. Share a playlist with another user

## Instructions:

Today is only the scaffolding of the app. It's a pretty big scaffold, but provided is some guidance. 

Create an empty web application project to start out your API, and add the following to your project

### Startup Class

1. Enable to use of Controllers
2. Enable the use of Identity
3. Register Identity with your ApplicationUser and your Identity DbContext
4. Register each of your databases
5. Register your interface with Dependency Injection
6. Set your routing to default to ` MapDefaultControllerRoute();`

### Controllers

Create 2 controllers:
1. SongsController
	- Inject in your interface `ISongsManager`
2. PlaylistsController
	- Scaffolod out an API with read/write actions
	- Don't do anything yet with this controller, it's here for our next lab.

### DbContext(s)
1. MusicDbContext that will hold the data for your playlist and songs specifically
    - Tables:
        - Songs
        - Playlists
        - SongsPlaylists
        - SharedPlaylists
    - Setup your composite keys
2. UsersDbContext that will hold the data of your users and permissions
     - no need to add any additional info after the basic setup
3. Seed 5 `Song` entities into your database

### Models

Using the repository design pattern, create a service named `SongsService` and an interface named `ISongsRepository` that can:
1. Create a Song
2. Get a Single Song
3. Get all Songs
4. Update a Song
5. Delete a Song

Create a few other models to prepare us for the next couple labs. Don't forget to set the appropriate composite keys in the `MusicDbContext` file:

1. Song 
```
    public class Song
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Artist {get; set; }
        public int Duration { get; set; }
    }
```

2. ApplicationUser (that derives from IdentityUser)
	- Add any additional information to this class you want to capture (example: FirstName, LastName)?

3. Playlist 
```
    public class Playlist
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string ListName { get; set; }

        public List<Song> Songs { get; set; }
    }
```
4. PlaylistsSongs
```
    public class PlaylistSongs
    {
        public int PlaylistId { get; set; }
        public int SongId { get; set; }

        public Song Song { get; set; }
        public Playlist Playlist { get; set; }
    }
```

5. SharedPlaylists
```
    public class SharedPlaylists
    {
        public string UserId { get; set; }
        public int PlaylistId { get; set; }
    }
```

### Additional

1. Create a migration for each of your databases
2. Create both databases with your migrations
3. Test out that you can do complete CRUD on your `Songs` table

We will continue to buid off of this app in lab 27....


## Tests

1. Test your `ISongsManager` service


## To Submit this Assignment

