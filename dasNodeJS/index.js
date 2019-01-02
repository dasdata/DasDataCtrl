const das = require("@dasdata/platform");

// data from sensors
var _data = '1.6|565|';  
// account token
var _aKey = '2dfb8b1e605f4f65b1574e92008224';
// dataset token
var _dsKey = '94e8c95df48447b2a85470b1210f16'; 

// send records to your database
das('send',_data,_dsKey,_aKey);
// get latest 200 records
 das('get', '',_dsKey, '');