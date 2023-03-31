# Perfect Fifth

[Homepage (with examples!)](https://mark-gerarts.github.io/perfect-fifth/)

Perfect Fifth is a Processing-like creative coding environment for F#. It is a
thin wrapper around [p5js](https://p5js.org), with some extra functional sugar
on top.

⚠️ This is a work in progress. A lot of the p5js functions are not implemented
yet. To check the current progress, take a look at the [reference
page](https://mark-gerarts.github.io/perfect-fifth/reference.html).

## Installation

If you have not done so yet, set up a Fable project. More info can be found on
the [Fable site](https://fable.io/docs/2-steps/your-first-fable-project.html).

Add the NuGet package:

```bash
dotnet add package PerfectFifth --prerelease
```

Make sure p5js is installed as a dependency:

```bash
npm i --save p5@^1.6.0
```

That's it! Take a look at the [usage](#usage) for the next steps.

## Examples

A part of the examples on the p5js site are ported to Perfect Fifth. You can
find the sketches and their source code on the [project
site](https://mark-gerarts.github.io/perfect-fifth/examples.html).

## Usage

You can create a sketch in four different ways, depending on your use case:

- Use `display` to render a single frame, without animation.
- Use `animate` to create an animation that updates itself based on time.
- Use `simulate` to create a stateful simulation.
- Use `play` to create a simulation that also handles input events.

### Display

Using `display`, you can draw a single frame and nothing more.

```fsharp
// Definition:
let display
  (node: Node) // Element to render the canvas.
  (draw: P5 -> Unit) // Draw function that gets called a single time.
  : Unit = ...
```

The first argument is `node`, the target HTML element where the sketch should be
rendered. It can be set in three different ways:

```fsharp
type Node =
    // The query selector of an element.
    | Selector of string
    // A Fable Browser.Dom.Element, e.g. the result of document.querySelector
    | Element of Browser.Types.Element
    // Nothing. Create the canvas yourself in `draw` using `createCanvas`, or
    // let P5 handle it.
    | NoNode
```

The second argument is the draw function that will be called a single time. It
gets passed the `p5` context variable, which is needed for all p5 functionality.

For example:

```fsharp
module DrawExample

open Browser.Dom
open P5.Core
open P5.Rendering
open P5.Color
open P5.Environment
open P5.Shape

let draw p5 =
    resizeCanvas p5 720 400
    stroke p5 (Grayscale 255)

    let y = (height p5 |> float) * 0.5
    let width = width p5 |> float

    background p5 (Grayscale 0)
    line2D p5 0 y width y

display (Selector ".canvas-wrapper") draw

// Or
display (Element (document.querySelector ".canvas-wrapper")) draw

// Or
display NoNode draw
```

### Animate

`animate` is used to create an animation. Its `draw` function gets passed the
elapsed milliseconds since the start of the sketch.

```fsharp
// Definition:
let animate
    (node: Node) // Element to render the canvas.
    (setup: P5 -> Unit) // Setup function that gets called once, before the sketch starts.
    (draw: P5 -> int -> Unit) // Draw function that receives the time elapsed in ms.
  : Unit = ...
```

TODO: add an example.

### Simulate

With `simulate` you can create a simulation that is able to update its state
every frame. The state can be any data type. For example, a simple counter can
use a single integer, while a complex simulation might use a big record type or
a class.

You provide an initial state in the setup function, which can then be updated
every step using the `update` function.

```fsharp
// Definition:
let simulate
    (node: Node) // Element to render the canvas.
    (setup: P5 -> 'a) // Setup function that gets called once, before the sketch starts. Returns the initial state.
    (update: P5 -> 'a -> 'a) // A function to step the state one iteration.
    (draw: P5 -> 'a -> Unit) // A function to draw something based on the current state.
    : Unit = ...
```

TODO: add an example.

### Play

Much the same as `simulate`, but `play` is able to handle input as well.

```fsharp
type EventHandler<'e, 'a> =
    // An event handler that only triggers side effects.
    | Effect of (P5 -> 'e -> Unit)
    // An event handler that updates the world state (and possibly triggers
    // side effects as well).
    | Update of (P5 -> 'e -> 'a -> 'a)

// A subscription binds an event type to an event handler.
type Subscription<'a> =
    | OnMouseMoved of EventHandler<MouseEvent, 'a>
    // ... and a lot more. See the reference.
    | OnWindowResized of EventHandler<UIEvent, 'a>

let play
    (node: Node) // Element to render the canvas.
    (setup: P5 -> 'a) // Setup function that gets called once, before the sketch starts. Returns the initial state.
    (update: P5 -> 'a -> 'a) // A function to step the state one iteration.
    (draw: P5 -> 'a -> Unit) // A function to draw something based on the current state.
    (subscriptions: Subscription<'a> list)// A list of subscriptions.
    : Unit = ...
```

```fsharp
module Example

open P5.Core
open P5.Shape
open P5.Color
open Browser.Types
open P5.Typography

type Shape =
    | Square
    | Circle

type State = { counter: int; shape: Shape }

// Set up the sketch and provide an initial state.
let setup p5 =
    createCanvas p5 100 100
    { counter = 0; shape = Circle } // Initial state.

// Update the state every render step.
let update p5 state =
    { state with counter = state.counter + 1 }

// Draw something based on the current state.
let draw p5 state =
    background p5 (Grayscale 51)

    match state.shape with
    | Circle -> circle p5 50 50 50
    | Square -> square p5 25 25 50

    text p5 (string state.counter) 40 15

// Alternate between square and circle when mouse is pressed. This is an event
// handler that updates the state.
let onMouseClicked p5 event state =
    let shape =
        match state.shape with
        | Circle -> Square
        | Square -> Circle

    { state with shape = shape }

// Multiple event handlers of the same type are perfectly possible. This one
// does not transform the state, and only has a side effect.
let onMouseClickedEff p5 event =
    let rand = System.Random()
    let r = rand.Next(0, 255)
    let g = rand.Next(0, 255)
    let b = rand.Next(0, 255)

    fill p5 (RGB(r, g, b))

// Event handlers get passed their respective JavaScript events (e.g.
// MouseEvent, UIEvent, ...).
let onMouseMoved p5 (event: MouseEvent) = printfn "%A" event.clientX

let subscriptions =
    [ OnMouseClicked(Update onMouseClicked)
      OnMouseClicked(Effect onMouseClickedEff)
      OnMouseMoved(Effect onMouseMoved) ]

play NoNode setup update draw subscriptions
```

## Preloading

TODO: explain preload alternatives.

TODO: Also, explain how to create a raw sketch, without animate/play/...

## Remarks

TODO: explain why p5 needs to be passed to everything.

TODO: explain function naming scheme (e.g. point -> point2D, color, etc).

## Tests

A basic test suite exists that simply checks every reference check to see if an
error is thrown. To use it, make sure the example site is running at port 8000:

```bash
$ ./scripts/build-and-serve-site
```

Then run:

```bash
$ npm run test:e2e
```

## Credits

Inspired by [Haskell's Gloss](http://gloss.ouroborus.net/), [Clojure's
Quil](https://github.com/quil/quil), and [aolney's Fable P5
Demo](https://github.com/aolney/fable-p5-demo). Made possible with
[Fable](https://fable.io/) and [p5js](https://p5js.org).
