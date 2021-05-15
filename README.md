# Choice Technical Assessment - DEV

This project was created to showcase Development knowledge in Angular and ASP.NET WebAPI.
The requirements to be assessed can be read on [this file](/Avaliacao-de-conhecimentos-tecnicos-DEV.pdf) (in Brazilian Portuguese).

## Step 1 - Back-end

The API is stored in /src/backend folder. This application must start first to serve the Front-end with data.

### About the architecture
This project is a monolith pretending to be have a Clean Architecture. To **K**eep **i**t **s**tupidly **s**imple, I've opt to only build the Clean Architecture as folders. But it's not *real*.

## Step 2 - Front-end

The user interface is stored in /src/frontend folder. This application was developed in Angular and to serve it, use the command:
```
$ ng serve -o
```

It will open your default web browser and load a simple user interface. 

## External Packages

This project were build using some external libraries and packages listed below:

- Backend
  - Microsoft.AspNetCore.Cors (to enable CORS on Dev environment)
  - Microsoft.EntityFrameworkCore
  - Swashbuckle.AspNetCore (Swagger - Open API)
 - Frontend
  - Angular Material Design
  - DevExtreme

## What could be better? 🤔
This is a job assessment, so I have no much time to spend in all features I would like to. I did the most I could with the time I had. But, if I had more time I'd like to:

### Improve performance on data fetching
Due the short time amount and the need to keep all the project portable, I opted to serve the data "as it is", in CSV files. This takes a bit more time to up the server on the first call (using DI and AddSingleton). I would like to have a better use of an ORM and all data in a real database. It should make the overall performance skyrocket.
The UCS.csv file has 1M UCs. **I had to limit the data fetching to 100k** because the application was consuming a lot of memory and not performing satisfactorily.
My first idea was to build a wrapper to deliver the data in slices. Something like that:
```json
{
  "itemsPerPage": 500,
  "totalItems": 10000,
  "currentPage": 1,  
  "totalPages": 20,
  "data":[
    {
      "Id": 1,
      "CustomerName": "Customer 1",
      ...
    },
    {
      "Id": 2,
      "CustomerName": "Customer 2",
      ...
    }
  ]
}
```
To make this work **properly** I would need to test A LOT, and sadly I had no time for... 😞

### Improve filters
It was requested to implement a filter as in [Microsoft REST API Guidelines](https://github.com/microsoft/api-guidelines/blob/vNext/Guidelines.md#97-filtering). I could not due the short amount of time to do it.

### UI Navigation
The user interface is too much simple! There's no navigation and also there's no data to persist. 
On the other hand, the [DevExtreme Datagrid](https://js.devexpress.com/Demos/WidgetsGallery/Demo/DataGrid/Overview/Angular/Light/) is a wonderful tool. It have a lot of options to filter, order and paginate data.

------------------------
## Conclusion
Well, this is not my masterpiece... I can do much better using proper databases and proper (large timed thought)  projects.