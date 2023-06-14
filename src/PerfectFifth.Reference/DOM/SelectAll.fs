module P5Reference.DOM.SelectAll

open P5.Core
open P5.DOM

let updateButton i (button: P5Element<Unit>) =
    button.setSize 100 30
    button.setPosition 0 (i * 30 |> float)

let draw p5 =
    createButton p5 "btn" |> ignore
    createButton p5 "2nd btn" |> ignore
    createButton p5 "3rd btn" |> ignore

    selectAll p5 "button" |> Array.iteri updateButton

let run node = display node draw
