// import { Guid } from "guid-typescript"

export class Movie{
    id: string = ""//Guid.create().toString()
    title: string = ""
    release: number = Date.now()
    director: string = ""
    rating: number = 0

}