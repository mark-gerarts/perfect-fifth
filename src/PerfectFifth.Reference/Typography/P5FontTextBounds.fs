module P5Reference.Typography.P5FontTextBounds

open P5.Core
open P5.Color
open P5.Environment
open P5.Shape
open P5.Typography

let textString = "Lorem ipsum dolor sit amet."

let preload p5 = loadFont p5 "assets/Regular.otf"

let draw p5 (font: P5Font) =
    background p5 (Grayscale 210)
    let bbox = font.textBoundsWithSize textString 10 30 12
    fill p5 (Grayscale 255)
    stroke p5 (Grayscale 0)
    rect p5 bbox.x bbox.y bbox.w bbox.h
    fill p5 (Grayscale 0)
    noStroke p5

    setTextFont p5 font
    setTextSize p5 12
    text p5 textString 10 30

let run node = displayWithPreload node preload draw
