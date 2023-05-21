module P5Reference.DOM.CreateButton

open P5.Core
open P5.Color
open P5.Rendering
open P5.DOM
open P5.Math

let changeBG p5 _ =
    randomInRange p5 0 255 |> Grayscale |> background p5

let setup p5 =
    createCanvas p5 100 100
    background p5 (Grayscale 0)
    let button = createButton p5 "click me"
    button.setPosition 0 0
    button.mousePressed (changeBG)

let draw p5 _ = ()

let run node = animate node setup draw
