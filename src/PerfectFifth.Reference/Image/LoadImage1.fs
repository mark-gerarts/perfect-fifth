module P5Reference.Image.LoadImage1

open P5.Core
open P5.Image

let draw p5 =
    let onSuccess img = image p5 img 0 0
    let onError error = console.log error

    loadImageWithCallbacks p5 "assets/laDefense.png" onSuccess onError |> ignore

let run node = display node draw
