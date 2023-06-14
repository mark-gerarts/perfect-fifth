module P5Reference.DOM.P5ElementStyle2

open P5.Core
open P5.Color
open P5.DOM
open P5.Events

let setup p5 =
    background p5 (Grayscale 200)
    let myDiv = createDiv p5 "I like gray."
    myDiv.setPosition 0 0
    myDiv.setStyle "z-index" "10"
    myDiv

let draw p5 (myDiv: P5Element<Unit>) =
    let fontSize = min (mouseX p5) 90.0
    myDiv.setStyle "font-size" (sprintf "%ipx" (int fontSize))
    console.log (sprintf "%0f px" fontSize)

let run node = simulate node setup noUpdate draw
