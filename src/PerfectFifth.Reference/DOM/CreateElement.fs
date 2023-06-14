module P5Reference.DOM.CreateElement

open P5.Core
open P5.DOM

let draw p5 =
    let h5 = createElementWithContent p5 "h5" "im an h5 p5.element!"
    h5.setStyle "color" "#00a1d3"
    h5.setPosition 0 0

let run node = display node draw
