(function (w) {

	var PROP = {
		ACTION: {
			ASSOCIATED_SAVE: 'CreateSaveAsync',
			ASSOCIATED_INDEX: 'Index'
		},
		MGE: {
			SUCCESS_SAVE: 'El registro fue guardado exitosamente!.',
			ERROR_SAVE: 'Error al guardar registro.',
			ERROR_REQUIRED: 'Existen campos sin completar.',
			ERROR_AT_LEAST_ONE: 'Debe seleccionar al menos un registro.',
			ERROR_COMMAND_FAIL: 'Error al ejecutar el comando. Reintente.'
		}
	}

	w.PROP = PROP;

})(window);
// -----------------------------------------------------------------
// FOCUS
// -----------------------------------------------------------------
$.fn.setFocus = function () {
	var el = this.get(0);
	var elemLen = el.value.length;

	if (!el.disabled) {
		el.selectionStart = elemLen;
		el.selectionEnd = elemLen;
		el.focus();
	}

	return this;
};


// -----------------------------------------------------------------
// EXTEND FOREACH FOR SUPPORT BROWSER <= IE7
// -----------------------------------------------------------------
if (!Array.prototype.forEach) {
	Array.prototype.forEach = function (fn, scope) {
		for (var i = 0, len = this.length; i < len; ++i) {
			fn.call(scope, this[i], i, this);
		}
	}
}


if (typeof String.prototype.trim !== 'function') {
	String.prototype.trim = function () {
		return this.replace(/^\s+|\s+$/g, '');
	}
}


// -----------------------------------------------------------------
// SETTING : REQUIRED, MAX-LENGTH, MIN-LENGTH
// -----------------------------------------------------------------
(function ($) {

	$.fn.setting = function (set) {

		var el = this;
		var validate = {
			numeric: function (event) {
				$(this).val($(this).val().replace(/[^\d].+/, ""));

				if ((event.which < 48 || event.which > 57)) {
					event.preventDefault();
				}
			},
			decimal: function (event) {
				$(this).val($(this).val().replace(/[^0-9\.]/g, ''));
				if ((event.which != 46 || $(this).val().indexOf('.') != -1) && (event.which < 48 || event.which > 57)) {
					event.preventDefault();
				}
			},
			date: function (event) { },
			text: function (event) { }
		}

		var setting = $.extend({
			required: undefined,
			minLength: undefined,
			maxLength: undefined,
			type: 'text'
		}, set);

		if (setting.required)
			el.attr('required', setting.required);

		if (setting.minLength)
			el.attr('minlength', setting.minLength);

		if (setting.maxLength)
			el.attr('maxlength', setting.maxLength);


		switch (setting.type) {
			case 'text':
				break;
			case 'numeric':
				el.on('keypress keyup blur', validate.numeric);
				break;
			case 'decimal':
				el.on('keypress keyup blur', validate.decimal);
				break;
			case 'date':
				// el.on('keypress keyup blur', validate.date);
				break;
			case 'email':
				// el.on('keypress keyup blur', validate.date);
				break;
			default:
				// el.on('keypress keyup blur', validate.text);
				break;
		}
	};

}(jQuery));
/* ============================================= */
function isEmail(email) {
	var regex = /^([a-zA-Z0-9_.+-])+\@(([a-zA-Z0-9-])+\.)+([a-zA-Z0-9]{2,4})+$/;
	return regex.test(email);
}

// AJAX
(function (w) {
	function success(data) {
		console.groupCollapsed('SUC');
		console.log(' -> ', data);
		console.groupEnd();
	}

	function error(xhr, status, thrown) {
		console.groupCollapsed('ERR');
		console.log(' -> ', xhr);
		console.log(' -> ', status);
		console.log(' -> ', thrown);
		console.groupEnd();
	}

	function callAjaxPost(ajax) {
		// dataType: "json"
		$.ajax({
			url: ajax.url,
			type: 'POST',
			data: ajax.data,
			beforeSend: function () {
				WAITING.Show();
			},
			success: ajax.success,
			error: ajax.error,
			complete: function () {
				WAITING.Hide();
			}
		});
	}

	function callAjaxGet(ajax) {
		$.ajax({
			url: ajax.url,
			type: 'GET',
			dataType: "json",
			data: ajax.data,
			beforeSend: function () {
				WAITING.Show();
			},
			success: ajax.success,
			error: ajax.error,
			complete: function () {
				WAITING.Hide();
			}
		});
	}

	function ajaxPost(obj) {
		var _url = obj.url;
		var _data = obj.data;
		var _success = obj.success || success;
		var _error = obj.error || error;

		callAjaxPost({
			url: _url,
			data: _data,
			success: _success,
			error: _error
		});
	}

	function ajaxGet(obj) {
		var _url = obj.url;
		var _data = obj.data;
		var _success = obj.success || success;
		var _error = obj.error || error;

		callAjaxGet({
			url: _url,
			data: _data,
			success: _success,
			error: _error
		});
	}

	w.AJAX_POST = ajaxPost;
	w.AJAX_GET = ajaxGet;

})(window);


// ALERT
(function (w) {

	var $template;
	var $body = document.querySelector('body');
	var $alert, alertTitle;

	function init() {

		var $alertNode = function () {
			var nodeDiv = document.createElement("div");
			nodeDiv.className = "alert alert-dismissible fade show";
			nodeDiv.setAttribute("data-control-container", "alert");
			nodeDiv.setAttribute("role", "alert");
			nodeDiv.setAttribute("style", "position: fixed; top: 5%; left: 0; right: 0; margin: auto; width: 75%; z-index: 1; box-shadow: 0 3px 3px -1px; transition: all .25s 0s;");

			var nodeButton = document.createElement("button");
			nodeButton.className = "close";
			nodeButton.setAttribute("type", "button");
			nodeButton.setAttribute("data-dismiss", "alert");
			nodeButton.setAttribute("aria-label", "Close");

			var nodeSpan = document.createElement("span");
			nodeSpan.setAttribute("aria-hidden", "true");
			nodeSpan.innerHTML = "x";

			var nodeStrong = document.createElement("strong");
			nodeStrong.innerHTML = alertTitle;

			var nodeSpanMge = document.createElement("span");
			nodeSpanMge.setAttribute("style", "margin: 0 .5em;");
			nodeSpanMge.classList.add('alert-message');


			nodeButton.appendChild(nodeSpan);

			nodeDiv.appendChild(nodeButton);
			nodeDiv.appendChild(nodeStrong);
			nodeDiv.appendChild(nodeSpanMge);

			return function (type, mge) {
				nodeDiv.classList.add(type);
				nodeDiv.querySelector('.alert-message').innerHTML = mge;

				return nodeDiv;
			}
		};
		var $alert = document.querySelector('[data-control-container="alert"]');

		if ($alert) {
			document.body.querySelector('[data-control-container="alert"]').remove();
		}

		$template = $alertNode();
	}

	function hide() {
		document.body.querySelector('[data-control-container="alert"]').classList.toggle('fadeOut-hide');
		return function () {
			document.body.querySelector('[data-control-container="alert"]').remove();
		}
	}

	function show(type, mge, time) {
		init();
		$alert = $template(type, mge);

		$body.appendChild($alert);
		if (time) {
			setTimeout(function () {

				var remove = hide();
				setTimeout(function () {
					remove();
				}, time);

			}, time);
		} else {
			$($alert).find('button.close').on('click', hide);
		}
	}

	function showError(mge, time) {
		alertTitle = 'Opps1 :/';
		show('alert-danger', mge, time);
	}
	function showSuccess(mge, time) {
		alertTitle = 'Vamos! :)';
		show('alert-success', mge, time);
	}
	function showWarning(mge, time) {
		alertTitle = 'Atención!';
		show('alert-warning', mge, time);
	}
	function showInfo(mge, time) {
		alertTitle = 'Info';
		show('alert-info', mge, time);
	}

	w.ALERT = {
		SHOW_ERROR: showError,
		SHOW_SUCCESS: showSuccess,
		SHOW_WARNING: showWarning,
		SHOW_INFO: showInfo
	};

})(window);


// POPUP
(function (w) {
	var $body = $('body');
	var $popupContainer = $('<div />', { class: 'gpp-popup-container' });

	var $divButtons = $('<div />')
		.append($('<button />', { class: 'gpp-button-small', text: 'Aceptar', id: "btnAcept" }))
		.append($('<button />', { class: 'gpp-button-small', text: 'Cancelar', id: "btnCancel" }));

	var $popupBox = $('<div />', { class: 'gpp-popup-box' })
		.append($('<header />')
			.append($('<p />')))
		.append($('<section />'))
		.append($('<footer />')
			.append($divButtons)
		);
	var $popupBtnClose = $('<a />', { class: 'gpp-popup-btnClose', text: 'X' });

	function show(html, setting) {
		$body.prepend(
			$popupContainer.append(
				$popupBox.append(
					$popupBtnClose.on('click', closePopup)
				)
			)
		);
		$popupBox.find(' > section').html(html);

		if (setting.title) {
			$popupBox.find(' > header > p').text(setting.title);
		}
		if (setting.height) {
			$popupBox.css('height', setting.height);
		}
		if (setting.width) {
			$popupBox.css('width', setting.width);
		}
	}

	function closePopup() {
		$popupBox.find('[class^=gpp-text]').remove();
		$popupBox.fadeOut('fast', function () {
			$popupContainer.fadeOut(function () {
				$popupBox.removeAttr('style');
				$popupContainer.removeAttr('style').remove();
			});
		});
	}


	w.Popup = {
		Show: show
	}

})(window);


// WAITING
(function (w) {
	var $body = $('body');
	var $waitingContainer = $('<div />', { class: 'gpp-waiting-container' });
	var $waitingImage = $('<div />', { class: 'gpp-waiting-image' });

	function show(html, setting) {
		$body.prepend(
			$waitingContainer.append(
				$waitingImage
			)
		);
	}

	function hide() {
		$waitingImage.remove();
		$waitingContainer.fadeOut(function () {
			$waitingImage.removeAttr('style');
			$waitingContainer.removeAttr('style').remove();
		});

	}

	w.WAITING = {
		Show: show,
		Hide: hide
	}

})(window);