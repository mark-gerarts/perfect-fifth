// TODO: this file has to be moved to an npm package. Ideally I'd just want this
// file included in this project, but packaging does not seem to work.
import * as p5 from 'p5';

export const createSketch = (sketch) => {
  let p5Sketch = (p) => {

    // For testing, delete me later.
    console.log(p);

    let state;

    p.setup = () => {
      state = sketch.setup(p)
    };

    p.draw = () => {
      state = sketch.update(p, state);
      sketch.draw(p, state);
    };

    // TODO: add more events
    // TODO: handle the event object
    p.mouseMoved = (e) => {
      sketch.eventHandler("MouseMoved")
    };
  }

  let node = null;
  if (sketch.node.tag === 0 || sketch.node.tag === 1) {
    node = sketch.node.fields[0];
  }

  new p5(p5Sketch, node);
};
