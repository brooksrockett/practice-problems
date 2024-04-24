//
// This is only a SKELETON file for the 'Gigasecond' exercise. It's been provided as a
// convenience to get you started writing code faster.
//

export const gigasecond = (date) => {
  // convert date to milliseconds
  let time = date.getTime()
  // convert 1 gigasecond to milliseconds (1e12)
  const seconds = 1e12
  // return date + 1 gs
  return new Date(time + seconds)
  // function can thus be shortened to:
    // const gigasecond = date => new Date(date.getTime() + 1e12)
};