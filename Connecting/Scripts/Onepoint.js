 // 百度地图API功能
        var map = new BMap.Map("allmap");
        map.enableScrollWheelZoom();
        var point = new BMap.Point(116.404, 39.915);
        map.centerAndZoom(point, 15);
        var marker = new BMap.Marker(point);  // 创建标注
        map.addOverlay(marker);               // 将标注添加到地图中
        marker.setAnimation(BMAP_ANIMATION_BOUNCE); //跳动的动画