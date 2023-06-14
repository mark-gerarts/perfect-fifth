module P5Reference.DOM.CreateAudio

open P5.Core
open P5.DOM

let draw p5 =
    let ele = createAudio p5 "assets/beat.mp3"

    // here we set the element to autoplay
    // The element will play as soon
    // as it is able to do so.
    ele.setAutoplay true

let run node = display node draw
