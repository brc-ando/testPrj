	jQuery.fn.rollover = function (settings) {
	settings = jQuery.extend({
		suffix: "_on"  //画像ファイル名につける接尾語の初期設定値
	}, settings);
	return this.each(function () {
		var default_img = $(this).attr("src");
		if (!default_img.match((settings.suffix))) {
			var point = default_img.lastIndexOf(".");
			var mouseover_img = default_img.slice(0, point) + settings.suffix + default_img.slice(point);
			var preload_img = new Image();
			preload_img.src = mouseover_img;
			$(this).hover(
		function () {
			$(this).attr("src", mouseover_img);
		},
		function () {
			$(this).attr("src", default_img);
		}
		);
		};
	});
};