# README for Hit Parade Management System

This C# program implements a Hit Parade management system, allowing users to manage a list of hits (songs, tracks, etc.) by performing various operations like adding, inserting, removing hits, swapping hits at different positions, and displaying hits based on search criteria.
Components:
Class Hit

    Contains properties for hit title and author.
    Overrides ToString() to display hit information.

Class HitParade

    Manages a list of Hit objects.
    Provides methods to add, insert, remove, and swap hits.
    Displays the list of hits and hits containing a specific word in the title.

Class GestioneHitParade

    Orchestrates user interaction through the console.
    Offers options to display the current hit parade, add a new hit, insert a new hit at a specified position, remove a hit at a certain position, swap hits at specific positions, display hits containing a specific word in the title, and exit the program.

How to Use:

    Run the Program:
        Compile and execute the Program.cs file.
        The program will prompt you with a menu to interact with various hit parade management functionalities.

    Choose Options:
        Select an option from the displayed menu by entering the respective number.
        Perform actions like displaying the current hit parade, adding new hits, manipulating hits' positions, searching for hits by specific words in their titles, etc.

Usage Notes:

    The program provides an interactive console-based interface for managing the hit parade.
    Options are available to perform different operations on the hit parade list.

Files:

    Hit.cs: Defines the structure and display functionalities for a hit.
    HitParade.cs: Manages the hit parade list with methods for hit manipulation and display.
    GestioneHitParade.cs: Facilitates user interaction and orchestrates the hit parade management functionalities through the console.

Feel free to modify or extend this code for personal or educational purposes. Enjoy managing your hit parade with this C# application!
