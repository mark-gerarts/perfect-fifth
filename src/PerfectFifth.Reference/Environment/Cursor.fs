module P5Reference.Environment.Cursor

open P5.Core
open P5.Environment
open P5.Shape
open P5.Events

let draw p5 _ =
    let width = width p5 |> float
    let height = height p5 |> float

    line p5 (width / 2.0) 0 (width / 2.0) height
    line p5 0 (height / 2.0) width (height / 2.0)

    match mouseX p5, mouseY p5 with
    | x, y when x < 50 && y < 50 -> cursor p5 Cross
    | x, y when x > 50 && y < 50 -> cursor p5 (Custom "progress")
    | x, y when x > 50 && y > 50 -> cursor p5 (Custom "https://avatars0.githubusercontent.com/u/1617169?s=16")
    | _ -> cursor p5 (Custom "grab")



let run node = animate node noSetup draw
