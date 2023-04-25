module P5Reference.Typography.LoadFont2

open P5.Core
open P5.Color
open P5.Environment
open P5.Shape
open P5.Typography
open P5.DOM

let preload p5 = loadFont p5 "assets/inconsolata.otf"

let draw p5 font =
    let myDiv = createDiv p5 "hello there"
    myDiv.style "font-family" "inconsolate"

let run node = displayWithPreload node preload draw
