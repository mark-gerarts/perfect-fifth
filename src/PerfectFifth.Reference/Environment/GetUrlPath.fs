module P5Reference.Environment.GetUrlPath

open P5.Core
open P5.Typography
open P5.Environment

let draw p5 =
    let urlPath = getURLPath p5

    urlPath
    |> List.ofArray
    |> List.indexed
    |> List.iter (fun (i, part) -> text p5 part 10 ((float i) * 20.0 + 20.0))

let run node = display node draw
