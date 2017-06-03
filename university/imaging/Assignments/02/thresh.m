function varargout = thresh(varargin)
% thresh - RGB Color Thresholder
% Simple GUI for thresholding color RGB images.
% Does not for grayscale thresholding.
% Note: Most comments in this file were inserted automatically by GUIDE.

% Begin initialization code - DO NOT EDIT
gui_Singleton = 1;
gui_State = struct('gui_Name',       mfilename, ...
                   'gui_Singleton',  gui_Singleton, ...
                   'gui_OpeningFcn', @thresh_OpeningFcn, ...
                   'gui_OutputFcn',  @thresh_OutputFcn, ...
                   'gui_LayoutFcn',  [] , ...
                   'gui_Callback',   []);
if nargin && ischar(varargin{1})
    gui_State.gui_Callback = str2func(varargin{1});
end

if nargout
    [varargout{1:nargout}] = gui_mainfcn(gui_State, varargin{:});
else
    gui_mainfcn(gui_State, varargin{:});
end
% End initialization code - DO NOT EDIT


% --- Executes just before thresh is made visible.
function thresh_OpeningFcn(hObject, eventdata, handles, varargin)
% This function has no output args, see OutputFcn.
% hObject    handle to figure
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)
% varargin   command line arguments to thresh (see VARARGIN)

% Choose default command line output for thresh
handles.output = hObject;
handles.A=0;
handles.D=0;
handles.min1=0; handles.max1=255;
handles.min2=0; handles.max2=255;
handles.min3=0; handles.max3=255;
axes(handles.axes1); axis off;
axes(handles.axes2); axis off;
axes(handles.axes3); axis off;
axes(handles.axes4); axis off;
axes(handles.axes5); axis off;
% Update handles structure
guidata(hObject, handles);

% UIWAIT makes thresh wait for user response (see UIRESUME)
% uiwait(handles.figure1);


% --- Outputs from this function are returned to the command line.
function varargout = thresh_OutputFcn(hObject, eventdata, handles) 
% varargout  cell array for returning output args (see VARARGOUT);
% hObject    handle to figure
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)

% Get default command line output from handles structure
varargout{1} = handles.output;


% --- Executes on button press in pushbutton1.
function pushbutton1_Callback(hObject, eventdata, handles)
% hObject    handle to pushbutton1 (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)
s = get(handles.edit1, 'String');
handles.A = evalin('base',s);
handles.D = 0;
drawAll(hObject, handles);
guidata(hObject, handles);


function drawAll(hObject, handles)
axes(handles.axes1);
imshow(handles.A); title('Original Image');
axes(handles.axes2);
imshow(handles.A(:,:,1)); title('R');
axes(handles.axes3);
imshow(handles.A(:,:,2)); title('G');
axes(handles.axes4);
imshow(handles.A(:,:,3)); title('B');
handles.min1 = round(get(handles.Rmin_slider,'Value'));
handles.max1 = round(get(handles.Rmax_slider,'Value'));
handles.min2 = round(get(handles.Gmin_slider,'Value'));
handles.max2 = round(get(handles.Gmax_slider,'Value'));
handles.min3 = round(get(handles.Bmin_slider,'Value'));
handles.max3 = round(get(handles.Bmax_slider,'Value'));
handles.D = [handles.A(:,:,1)>=handles.min1 & handles.A(:,:,1)<=handles.max1 & handles.A(:,:,2)>=handles.min2 & handles.A(:,:,2)<=handles.max2 & handles.A(:,:,3)>=handles.min3 & handles.A(:,:,3)<=handles.max3];
axes(handles.axes5);
if get(handles.overlayCheckBox,'Value')==0
    imshow(handles.D); title('Mask');
else
    for i=1:3
        Overlay(:,:,i) = handles.D .* double(handles.A(:,:,i));
    end;
    Overlay = uint8(Overlay);
    imshow(Overlay); title('Mask with Overlay');
end;
guidata(hObject, handles);


function updateR(hObject, handles)
handles.min1 = round(get(handles.Rmin_slider,'Value'));
handles.max1 = round(get(handles.Rmax_slider,'Value'));
handles.min2 = round(get(handles.Gmin_slider,'Value'));
handles.max2 = round(get(handles.Gmax_slider,'Value'));
handles.min3 = round(get(handles.Bmin_slider,'Value'));
handles.max3 = round(get(handles.Bmax_slider,'Value'));
set(handles.Rtext,'String',[num2str(handles.min1),'<=R<=',num2str(handles.max1)]);
handles.D = [handles.A(:,:,1)>=handles.min1 & handles.A(:,:,1)<=handles.max1 & handles.A(:,:,2)>=handles.min2 & handles.A(:,:,2)<=handles.max2 & handles.A(:,:,3)>=handles.min3 & handles.A(:,:,3)<=handles.max3];
axes(handles.axes5);
if get(handles.overlayCheckBox,'Value')==0
    imshow(handles.D); title('Mask');
else
    for i=1:3
        Overlay(:,:,i) = handles.D .* double(handles.A(:,:,i));
    end;
    Overlay = uint8(Overlay);
    imshow(Overlay); title('Mask with Overlay');
end;
guidata(hObject, handles);


function updateG(hObject, handles)
handles.min1 = round(get(handles.Rmin_slider,'Value'));
handles.max1 = round(get(handles.Rmax_slider,'Value'));
handles.min2 = round(get(handles.Gmin_slider,'Value'));
handles.max2 = round(get(handles.Gmax_slider,'Value'));
handles.min3 = round(get(handles.Bmin_slider,'Value'));
handles.max3 = round(get(handles.Bmax_slider,'Value'));
set(handles.Gtext,'String',[num2str(handles.min2),'<=G<=',num2str(handles.max2)]);
handles.D = [handles.A(:,:,1)>=handles.min1 & handles.A(:,:,1)<=handles.max1 & handles.A(:,:,2)>=handles.min2 & handles.A(:,:,2)<=handles.max2 & handles.A(:,:,3)>=handles.min3 & handles.A(:,:,3)<=handles.max3];
axes(handles.axes5);
if get(handles.overlayCheckBox,'Value')==0
    imshow(handles.D); title('Mask');
else
    for i=1:3
        Overlay(:,:,i) = handles.D .* double(handles.A(:,:,i));
    end;
    Overlay = uint8(Overlay);
    imshow(Overlay); title('Mask with Overlay');
end;
guidata(hObject, handles);


function updateB(hObject, handles)
handles.min1 = round(get(handles.Rmin_slider,'Value'));
handles.max1 = round(get(handles.Rmax_slider,'Value'));
handles.min2 = round(get(handles.Gmin_slider,'Value'));
handles.max2 = round(get(handles.Gmax_slider,'Value'));
handles.min3 = round(get(handles.Bmin_slider,'Value'));
handles.max3 = round(get(handles.Bmax_slider,'Value'));
set(handles.Btext,'String',[num2str(handles.min3),'<=B<=',num2str(handles.max3)]);
handles.D = [handles.A(:,:,1)>=handles.min1 & handles.A(:,:,1)<=handles.max1 & handles.A(:,:,2)>=handles.min2 & handles.A(:,:,2)<=handles.max2 & handles.A(:,:,3)>=handles.min3 & handles.A(:,:,3)<=handles.max3];
axes(handles.axes5);
if get(handles.overlayCheckBox,'Value')==0
    imshow(handles.D); title('Mask');
else
    for i=1:3
        Overlay(:,:,i) = handles.D .* double(handles.A(:,:,i));
    end;
    Overlay = uint8(Overlay);
    imshow(Overlay); title('Mask with Overlay');
end;


function edit1_Callback(hObject, eventdata, handles)
% hObject    handle to edit1 (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)


% --- Executes during object creation, after setting all properties.
function edit1_CreateFcn(hObject, eventdata, handles)
% hObject    handle to edit1 (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    empty - handles not created until after all CreateFcns called
if ispc && isequal(get(hObject,'BackgroundColor'), get(0,'defaultUicontrolBackgroundColor'))
    set(hObject,'BackgroundColor','white');
end


% --- Executes on button press in pushbutton2.
function pushbutton2_Callback(hObject, eventdata, handles)
% hObject    handle to pushbutton2 (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)
s = get(handles.edit2, 'String');
handles.min1 = round(get(handles.Rmin_slider,'Value'));
handles.max1 = round(get(handles.Rmax_slider,'Value'));
handles.min2 = round(get(handles.Gmin_slider,'Value'));
handles.max2 = round(get(handles.Gmax_slider,'Value'));
handles.min3 = round(get(handles.Bmin_slider,'Value'));
handles.max3 = round(get(handles.Bmax_slider,'Value'));
handles.D = [handles.A(:,:,1)>=handles.min1 & handles.A(:,:,1)<=handles.max1 & handles.A(:,:,2)>=handles.min2 & handles.A(:,:,2)<=handles.max2 & handles.A(:,:,3)>=handles.min3 & handles.A(:,:,3)<=handles.max3];
assignin ('base', s, handles.D);
guidata(hObject, handles);


function edit2_Callback(hObject, eventdata, handles)
% hObject    handle to edit2 (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)



% --- Executes during object creation, after setting all properties.
function edit2_CreateFcn(hObject, eventdata, handles)
% hObject    handle to edit2 (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    empty - handles not created until after all CreateFcns called
if ispc && isequal(get(hObject,'BackgroundColor'), get(0,'defaultUicontrolBackgroundColor'))
    set(hObject,'BackgroundColor','white');
end


% --- Executes on slider movement.
function Rmin_slider_Callback(hObject, eventdata, handles)
% hObject    handle to Rmin_slider (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)
updateR(hObject, handles);
guidata(hObject, handles);


% --- Executes during object creation, after setting all properties.
function Rmin_slider_CreateFcn(hObject, eventdata, handles)
% hObject    handle to Rmin_slider (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    empty - handles not created until after all CreateFcns called
if isequal(get(hObject,'BackgroundColor'), get(0,'defaultUicontrolBackgroundColor'))
    set(hObject,'BackgroundColor',[.9 .9 .9]);
end


% --- Executes on slider movement.
function Rmax_slider_Callback(hObject, eventdata, handles)
% hObject    handle to Rmax_slider (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)
updateR(hObject, handles);
guidata(hObject, handles);

% --- Executes during object creation, after setting all properties.
function Rmax_slider_CreateFcn(hObject, eventdata, handles)
% hObject    handle to Rmax_slider (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    empty - handles not created until after all CreateFcns called
if isequal(get(hObject,'BackgroundColor'), get(0,'defaultUicontrolBackgroundColor'))
    set(hObject,'BackgroundColor',[.9 .9 .9]);
end


% --- Executes on slider movement.
function Gmin_slider_Callback(hObject, eventdata, handles)
% hObject    handle to Gmin_slider (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)
updateG(hObject, handles);
guidata(hObject, handles);

% --- Executes during object creation, after setting all properties.
function Gmin_slider_CreateFcn(hObject, eventdata, handles)
% hObject    handle to Gmin_slider (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    empty - handles not created until after all CreateFcns called
if isequal(get(hObject,'BackgroundColor'), get(0,'defaultUicontrolBackgroundColor'))
    set(hObject,'BackgroundColor',[.9 .9 .9]);
end


% --- Executes on slider movement.
function Gmax_slider_Callback(hObject, eventdata, handles)
% hObject    handle to Gmax_slider (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)
updateG(hObject, handles);
guidata(hObject, handles);

% --- Executes during object creation, after setting all properties.
function Gmax_slider_CreateFcn(hObject, eventdata, handles)
% hObject    handle to Gmax_slider (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    empty - handles not created until after all CreateFcns called
if isequal(get(hObject,'BackgroundColor'), get(0,'defaultUicontrolBackgroundColor'))
    set(hObject,'BackgroundColor',[.9 .9 .9]);
end


% --- Executes on slider movement.
function Bmin_slider_Callback(hObject, eventdata, handles)
% hObject    handle to Bmin_slider (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)
updateB(hObject, handles);
guidata(hObject, handles);


% --- Executes during object creation, after setting all properties.
function Bmin_slider_CreateFcn(hObject, eventdata, handles)
% hObject    handle to Bmin_slider (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    empty - handles not created until after all CreateFcns called

% Hint: slider controls usually have a light gray background.
if isequal(get(hObject,'BackgroundColor'), get(0,'defaultUicontrolBackgroundColor'))
    set(hObject,'BackgroundColor',[.9 .9 .9]);
end


% --- Executes on slider movement.
function Bmax_slider_Callback(hObject, eventdata, handles)
% hObject    handle to Bmax_slider (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)
updateB(hObject, handles);
guidata(hObject, handles);


% --- Executes during object creation, after setting all properties.
function Bmax_slider_CreateFcn(hObject, eventdata, handles)
% hObject    handle to Bmax_slider (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    empty - handles not created until after all CreateFcns called

% Hint: slider controls usually have a light gray background.
if isequal(get(hObject,'BackgroundColor'), get(0,'defaultUicontrolBackgroundColor'))
    set(hObject,'BackgroundColor',[.9 .9 .9]);
end


% --- Executes on button press in overlayCheckBox.
function overlayCheckBox_Callback(hObject, eventdata, handles)
% hObject    handle to overlayCheckBox (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)
handles.min1 = round(get(handles.Rmin_slider,'Value'));
handles.max1 = round(get(handles.Rmax_slider,'Value'));
handles.min2 = round(get(handles.Gmin_slider,'Value'));
handles.max2 = round(get(handles.Gmax_slider,'Value'));
handles.min3 = round(get(handles.Bmin_slider,'Value'));
handles.max3 = round(get(handles.Bmax_slider,'Value'));
set(handles.Btext,'String',[num2str(handles.min3),'<=B<=',num2str(handles.max3)]);
handles.D = [handles.A(:,:,1)>=handles.min1 & handles.A(:,:,1)<=handles.max1 & handles.A(:,:,2)>=handles.min2 & handles.A(:,:,2)<=handles.max2 & handles.A(:,:,3)>=handles.min3 & handles.A(:,:,3)<=handles.max3];
axes(handles.axes5);
if get(handles.overlayCheckBox,'Value')==0
    imshow(handles.D); title('Mask');
else
    for i=1:3
        Overlay(:,:,i) = handles.D .* double(handles.A(:,:,i));
    end;
    Overlay = uint8(Overlay);
    imshow(Overlay); title('Mask with Overlay');
end;
