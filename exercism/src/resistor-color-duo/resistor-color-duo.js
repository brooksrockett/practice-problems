//
// This is only a SKELETON file for the 'Resistor Color Duo' exercise. It's been provided as a
// convenience to get you started writing code faster.
//

export const colorCode = (color) => {
  return COLORS.indexOf(color);
};

export const COLORS = ['black','brown','red','orange','yellow','green','blue','violet','grey','white'];

export const decodedValue = (input) => {
  return colorCode(input[0])*10 + colorCode(input[1]);
};
