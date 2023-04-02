module P5Reference.Events.Touches

open P5.Core
open P5.Color
open P5.Events
open P5.Typography

let draw p5 =
    clear p5
    let display = touches p5 |> Array.length |> sprintf "%i touches"
    text p5 display 5 10

let run node = display node draw
