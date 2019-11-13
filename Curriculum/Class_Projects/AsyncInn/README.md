# Async Inn Wireframes


## Overview

Within the Assets folder, is a series of ***suggested*** wireframes for the Async Inn Inventory Management Site. You may choose to follow this wireframe exactly as is, or you may choose to customize it to better fit your design style. 

Use these wireframes as a guideline of what information and functionality should be available within the site. 

## Pages
Below is a high overview of each of the pages. In addition to the explanations, refer to the provided wireframes to gain an understanding of the website's functionality.

### Home

Home page for the whole site. This page will consist of just a basic introduction. Find your own images to supply the homepage with. 

### Hotels

Route: `/Hotels`

1. The Hotels page will display basic information about each hotel. 
2. When selecting the name of each hotel, the user will be redirected to a details page that shows the individual details of each hotel. 
3. The details page of each hotel will consist of all the properties of the hotel in addition to a list of all the hotel rooms that the hotel contains. 
4. The user then has the option to add a new hotel room to the hotel, view the details about an individual hotel room, or click on the room type and view the details about the room itself, such as layout and amenities. 
5. From the `Hotels` endpoint, the user will also be able to Create and Update hotel details. 
6. The removal of a hotel can be done on the Hotels details page. Upon selection of the hotel removal, the hotel will be removed from the database...in addition to all hotel rooms that are connected to that Hotel.

### Hotel Room

Route: `/HotelRoom`

This endpoint will allow the following actions: 
1. Create a HotelRoom
2. Update a HotelRoom
3. Remove a HotelRoom
4. View a HotelRoom

Remember that both the `Room Number` and `HotelID` are the composite keys for this table. Both of these peices of information should be included when viewing and updating an individual Hotel Room.

### Rooms

Route: `/Rooms`

The Rooms endpoint will all for the following actions:

1. The Rooms page will display all the basic information about the rooms in the database.
2. View Room details page will show the information specific to the indvidual room as well as all the amenities that are associated with a specific room. Each line item in the amenities list contains an "X", where the user can choose to remove an amentity from a specific room.
2. Create a Room is found on the Rooms home page, where a user can create a new room to choose from for future hotels.
3. There is no need to "update" a room. Only add a new amentity to the room. This can be done through the "ADD" button on the room details page. 
4. Remove Room
   - When removing a room from the database, be sure to also remove all HotelRooms that use that room, as well as all amenities that are tied to that room. 

### Room Amenities

Route: `/RoomAmenities`

When adding a new amentity to a room, the /RoomAmenties page will associate the room and the specific amentity together. 

When a specific amenity gets removed from a specific room, the RoomAmenities Controller /delete action should target the individual amenity for the specific room from the database. 

### Amenities 

Route: `/Amenities`

1. This page will show all possible amenities in the database
2. This controller will allow the ability to create an individual amentity. 
3. The user will also be able to delete amentities from the list. 
4. There is no need to "update" an amenity. Only create and delete. 