
(function () {
    'use strict';

    var qr = new QCodeDecoder();


    if (!(qr.isCanvasSupported() && qr.hasGetUserMedia())) {
        alert('Your browser doesn\'t match the required specs.');
        throw new Error('Canvas and getUserMedia are required');
    }

    var video = document.querySelector('video');
    var pinuse = document.querySelector('#pinuse');
    var inuse = document.querySelector('#inuse');
    var free = document.querySelector('#free');
    var broken = document.querySelector('#broken');
    var overcyclelife = document.querySelector('#overcyclelife');
    var repairing = document.querySelector('#repairing');

    var scan = document.querySelector('#scan');

    var stop = document.querySelector('#stop');

    var mydate = new Date();
    //mydate = mydate.toUTCString();
    var str;
    var hh;
    var mm;
    var add;
    str = (mydate.getMonth() + 1) + "/";
    str += mydate.getDate() + "/";
    str += mydate.getFullYear() + " ";
    hh = mydate.getHours() - 8;
    // if (hh < 10) hh = '0' + hh;   
    if (hh > 12) {
        hh -= 12;
        add = " PM";
    } else {
        add = " AM";
    }
    str += hh + ":";
    mm = mydate.getMinutes();
    if (mm < 10) mm = '0' + mm;
    str += mm;
    str += add;
    console.log(str);

    var ar = new Array();

    function resultHandlerpinuse(err, result) {
        if (err)
            return console.log(err.message);
        //alert(result);
        console.log(result);

        ar.push(result);
        console.log(ar); 
    }

    function resultHandlerinuse(err, result) {
        if (err)
            return console.log(err.message);
        alert(result);
        window.location.href = "http://connecting20180812.chinacloudsites.cn/TurnoverBoxes/InuseEdit/" + result;  
    }

    function resultHandlerfree(err, result) {
        if (err)
            return console.log(err.message);
        alert(result);
        window.location.href = "http://connecting20180812.chinacloudsites.cn/TurnoverBoxes/FreeEdit/" + result;
    }

    function resultHandlerbroken(err, result) {
        if (err)
            return console.log(err.message);
        alert(result);
        window.location.href = "http://connecting20180812.chinacloudsites.cn/TurnoverBoxes/BrokenEdit/" + result;
    }

    function resultHandlerovercyclelife(err, result) {
        if (err)
            return console.log(err.message);
        alert(result);
        window.location.href = "http://connecting20180812.chinacloudsites.cn/TurnoverBoxes/OvercyclelifeEdit/" + result;
    }

    function resultHandlerrepairing(err, result) {
        if (err)
            return console.log(err.message);
        alert(result);
        window.location.href = "http://connecting20180812.chinacloudsites.cn/TurnoverBoxes/RepairingEdit/" + result;
    }

    function resultHandlerscan(err, result) {
        if (err)
            return console.log(err.message);
        alert(result);

        //window.location.href = "http://connecting20180812.chinacloudsites.cn/TurnoverBoxes/RepairingEdit/" + result;
    }
    // prepare a canvas element that will receive
    // the image to decode, sets the callback for
    // the result and then prepares the
    // videoElement to send its source to the
    // decoder.

    pinuse.onclick = function () { 
        var model = {
            Turnoverbox_id: "T003",
            Status: "In use",
            Time: str,
            Enduser: "BOSCH",
            Pallet_id: "P001"
        };

        $.ajax({
            type: "POST",
            data: JSON.stringify(model),
            url: "Turnoverboxes/pqr",
            contentType: "application/json"
        }).done(function (res) {
            console.log('res', res);
            // Do something with the result :) 
        });

        var model2 = {
            Turnoverbox_id: "T004",
            Status: "In use",
            Time: str,
            Enduser: "BOSCH",
            Pallet_id: "P001"
        };

        $.ajax({
            type: "POST",
            data: JSON.stringify(model2),
            url: "Turnoverboxes/pqr2",
            contentType: "application/json"
        }).done(function (res) {
            console.log('res', res);
            // Do something with the result :) 
        });

        var model3 = {
            Turnoverbox_id: "T005",
            Status: "In use",
            Time: str,
            Enduser: "BOSCH",
            Pallet_id: "P001"
        };

        $.ajax({
            type: "POST",
            data: JSON.stringify(model3),
            url: "Turnoverboxes/pqr3",
            contentType: "application/json"
        }).done(function (res) {
            console.log('res', res);
            // Do something with the result :) 
        });

        var model4 = {
            Turnoverbox_id: "T006",
            Status: "In use",
            Time: str,
            Enduser: "BOSCH",
            Pallet_id: "P001"
        };

        $.ajax({
            type: "POST",
            data: JSON.stringify(model4),
            url: "Turnoverboxes/pqr4",
            contentType: "application/json"
        }).done(function (res) {
            console.log('res', res);
            // Do something with the result :) 
        });

        qr.decodeFromCamera(video, resultHandlerpinuse);
    };

    inuse.onclick = function () {
        qr.decodeFromCamera(video, resultHandlerinuse);
    };
    free.onclick = function () {
        qr.decodeFromCamera(video, resultHandlerfree);
    };
    broken.onclick = function () {
        qr.decodeFromCamera(video, resultHandlerbroken);
    };
    overcyclelife.onclick = function () {
        qr.decodeFromCamera(video, resultHandlerovercyclelife);
    };
    repairing.onclick = function () {
        qr.decodeFromCamera(video, resultHandlerrepairing);
    };
    // attach some event handlers to reset and
    // stop whenever we want.

    stop.onclick = function () {
        qr.stop();
        window.location.href = "http://connecting20180812.chinacloudsites.cn/TurnoverBoxes/Index";
    };
})();
