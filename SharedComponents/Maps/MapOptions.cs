﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SharedComponents.Maps
{
    /// <summary>
    /// MapOptions object used to define the properties that can be set on a Map.
    /// </summary>
    public class MapOptions
    {
        /// <summary>
        /// Color used for the background of the Map div. 
        /// This color will be visible when tiles have not yet loaded as the user pans. 
        /// This option can only be set when the map is initialized.
        /// </summary>
        public string backgroundColor { get; set; }

        /// <summary>
        /// The initial Map center. Required.
        /// </summary>
        public LatLngLiteral center { get; set; }

        /// <summary>
        /// When false, map icons are not clickable. 
        /// A map icon represents a point of interest, also known as a POI. 
        /// By default map icons are clickable.
        /// </summary>
        public bool clickableIcons { get; set; }

        /// <summary>
        /// Enables/disables all default UI. May be overridden individually.
        /// </summary>
        public bool disableDefaultUI { get; set; }

        /// <summary>
        /// Enables/disables zoom and center on double click. Enabled by default.
        /// </summary>
        public bool disableDoubleClickZoom { get; set; }

        /// <summary>
        /// If false, prevents the map from being dragged. Dragging is enabled by default.
        /// </summary>
        public bool draggable { get; set; }

        /// <summary>
        /// The name or url of the cursor to display when mousing over a draggable map. 
        /// This property uses the css cursor attribute to change the icon. 
        /// As with the css property, you must specify at least one fallback cursor that is not a URL. 
        /// For example: draggableCursor: 'url(http://www.example.com/icon.png), auto;'.
        /// </summary>
        public string draggableCursor { get; set; }

        /// <summary>
        /// The name or url of the cursor to display when the map is being dragged. 
        /// This property uses the css cursor attribute to change the icon. 
        /// As with the css property, you must specify at least one fallback cursor that is not a URL. 
        /// For example: draggingCursor: 'url(http://www.example.com/icon.png), auto;'.
        /// </summary>
        public string draggingCursor { get; set; }

        /// <summary>
        /// The enabled/disabled state of the Fullscreen control.
        /// </summary>
        public bool fullscreenControl { get; set; }

        /// <summary>
        /// The display options for the Fullscreen control.
        /// </summary>
        public FullscreenControlOptions fullscreenControlOptions { get; set; }

        /// <summary>
        /// This setting controls how the API handles gestures on the map. Allowed values:
        /// "cooperative": Scroll events and one-finger touch gestures scroll the page, and do not zoom or pan the map. Two-finger touch gestures pan and zoom the map. Scroll events with a ctrl key or ⌘ key pressed zoom the map. In this mode the map cooperates with the page.
        /// "greedy": All touch gestures and scroll events pan or zoom the map.
        /// "none": The map cannot be panned or zoomed by user gestures.
        /// "auto": (default) Gesture handling is either cooperative or greedy, depending on whether the page is scrollable or in an iframe.
        /// </summary>
        public string gestureHandling { get; set; }

        /// <summary>
        /// The heading for aerial imagery in degrees measured clockwise from cardinal direction North. 
        /// Headings are snapped to the nearest available angle for which imagery is available.
        /// </summary>
        public int heading { get; set; }

        /// <summary>
        /// The heading for aerial imagery in degrees measured clockwise from cardinal direction North. 
        /// Headings are snapped to the nearest available angle for which imagery is available.
        /// </summary>
        public bool keyboardShortcuts { get; set; }

        /// <summary>
        /// The initial enabled/disabled state of the Map type control.
        /// </summary>
        public bool mapTypeControl { get; set; }

        /// <summary>
        /// The initial display options for the Map type control.
        /// </summary>
        public MapTypeControlOptions mapTypeControlOptions { get; set; }

        /// <summary>
        /// The initial Map mapTypeId. Defaults to ROADMAP.
        /// </summary>
        public MapTypeId mapTypeId { get; set; }

        /// <summary>
        /// The maximum zoom level which will be displayed on the map. 
        /// If omitted, or set to null, the maximum zoom from the current map type is used instead. 
        /// Valid values: Integers between zero, and up to the supported maximum zoom level.
        /// </summary>
        public int maxZoom { get; set; }

        /// <summary>
        /// The minimum zoom level which will be displayed on the map. 
        /// If omitted, or set to null, the minimum zoom from the current map type is used instead. 
        /// Valid values: Integers between zero, and up to the supported maximum zoom level.
        /// </summary>
        public int minZoom { get; set; }

        /// <summary>
        /// If true, do not clear the contents of the Map div.
        /// </summary>
        public bool noClear { get; set; }

        /// <summary>
        /// The enabled/disabled state of the Pan control.
        /// </summary>
        public bool panControl { get; set; }

        /// <summary>
        /// The display options for the Pan control.
        /// </summary>
        public PanControlOptions panControlOptions { get; set; }

        /// <summary>
        /// Defines a boundary that restricts the area of the map accessible to users. 
        /// When set, a user can only pan and zoom while the camera view stays inside the limits of the boundary.
        /// </summary>
        public MapRestriction restriction { get; set; }

        /// <summary>
        /// The enabled/disabled state of the Rotate control.
        /// </summary>
        public bool rotateControl { get; set; }

        /// <summary>
        /// The display options for the Rotate control.
        /// </summary>
        public RotateControlOptions rotateControlOptions { get; set; }

        /// <summary>
        /// The initial enabled/disabled state of the Scale control.
        /// </summary>
        public bool scaleControl { get; set; }

        /// <summary>
        /// The initial display options for the Scale control.
        /// </summary>
        public ScaleControlOptions scaleControlOptions { get; set; }


    }
}