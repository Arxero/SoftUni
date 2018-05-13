//my own solution
function attachEventsListeners() {
  let input = document.getElementById('inputDistance');
  let button = document.getElementById('convert');
  let metric = document.getElementById('inputUnits');
  let metric2 = document.getElementById('outputUnits');
  let metricValue = metric.value;
  let metricValue2 = metric2.value;


  metric.addEventListener('change', function () {
    metricValue = metric.value;
  });//end of change event

  metric2.addEventListener('change', function () {
    metricValue2 = metric2.value;
  });//end of change event

  button.addEventListener('click', function () {
    let meters = convertToMeters(Number(input.value), metricValue);
    let result = convertToSelected(meters, metricValue2);
    document.getElementById('outputDistance').value = result;
  });//end of click event

  function convertToMeters(number, metric) {
    let inMeters = 0;
    switch (metric) {
      case 'km': inMeters = number * 1000; break;
      case 'm': inMeters = number * 1; break;
      case 'cm': inMeters = number * 0.01; break;
      case 'mm': inMeters = number * 0.001; break;
      case 'mi': inMeters = number * 1609.34; break;
      case 'yrd': inMeters = number * 0.9144; break;
      case 'ft': inMeters = number * 0.3048; break;
      case 'in': inMeters = number * 0.0254; break;
    }
    return inMeters;
  };

  function convertToSelected(number, metric) {
    let result = 0;
    switch (metric) {
      case 'km': result = number / 1000; break;
      case 'm': result = number / 1; break;
      case 'cm': result = number / 0.01; break;
      case 'mm': result = number / 0.001; break;
      case 'mi': result = number / 1609.34; break;
      case 'yrd': result = number / 0.9144; break;
      case 'ft': result = number / 0.3048; break;
      case 'in': result = number / 0.0254; break;
    }
    return result;
  };

}

// //judge 100/100
// function attachEventsListeners() {
 
//   let distanceObj = {
//       km: 1000,
//       m: 1,
//       cm: 0.01,
//       mm: 0.001,
//       mi: 1609.34,
//       yrd: 0.9144,
//       ft: 0.3048,
//       in: 0.0254,
//   };

//   let button = document.getElementById('convert');
//   button.addEventListener('click', convert);

//   function convert() {
//       let inputUnits = document.querySelector('#inputUnits').options[document.querySelector('#inputUnits').selectedIndex].value;
//       let outputUnits = document.querySelector('#outputUnits').options[document.querySelector('#outputUnits').selectedIndex].value;
//       let inputUserValue = Number(document.getElementById('inputDistance').value);
//       let output = inputUserValue * distanceObj[inputUnits] / distanceObj[outputUnits];
//       document.getElementById('outputDistance').value = output;
//   }
// }