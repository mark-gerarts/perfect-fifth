module P5Reference.Events.Key

open P5.Core
open P5.Color
open P5.Typography
open P5.Events

let setup p5 =
    fill p5 (RGB(245, 123, 158))
    setTextSize p5 50

let draw p5 _ =
    background p5 (Grayscale 200)
    text p5 (key p5) 33 65 // Display last key pressed.

let run node = animate node setup draw
